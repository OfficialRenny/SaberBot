using DelegateDecompiler;
using Microsoft.EntityFrameworkCore;
using Saber.Database;
using Saber.Database.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.Services
{
    public class ItemService
    {
        private readonly Db _db;

        public ItemService(Db db)
        {
            _db = db;
        }

        public IEnumerable<ShopItem> GetShopItems()
        {
            return
                _db.ShopItems
                .Include(s => s.Item)
                .Where(s => s.IsInStock)
                .Decompile();
        }

        public ShopItem? GetShopItem(string itemId)
            => GetShopItem(new Guid(itemId));

        public ShopItem? GetShopItem(Guid itemId) =>
            _db.ShopItems
            .Include(s => s.Item)
            .FirstOrDefault(s => s.Id == itemId);

        public ShopItem CreateShopItem(ShopItem item)
        {
            _db.ShopItems.Add(item);
            _db.SaveChanges();
            return item;
        }

        public ShopItem ModifyShopItem(string itemId, Action<ShopItem> action)
            => ModifyShopItem(new Guid(itemId), action);

        public ShopItem ModifyShopItem(Guid itemId, Action<ShopItem> action)
        {
            var shopItem = GetShopItem(itemId);
            if (shopItem == null)
                throw new Exception($"Shop item with id {itemId} does not exist.");
            
            return ModifyShopItem(shopItem, action);
        }

        public ShopItem ModifyShopItem(ShopItem item, Action<ShopItem> action)
        {
            action(item);
            _db.SaveChanges();

            return item;
        }

        public Inventory GetInventory(ulong discordId)
        {
            return
                _db.Inventories
                .Include(i => i.UserProfile)
                .Include(i => i.OwnedItems)
                .First(i => i.UserProfile.DiscordId == discordId);
        }

        public IEnumerable<OwnedItem> GetOwnedItems(ulong discordId)
        {
            return
                _db.OwnedInventoryItems
                .Include(o => o.Inventory.UserProfile)
                .Include(o => o.Item)
                .Where(o => o.Inventory.UserProfile.DiscordId == discordId && o.Quantity > 0);
        }

        public OwnedItem? GetOwnedItem(ulong discordId, string itemId)
            => GetOwnedItem(discordId, new Guid(itemId));

        public OwnedItem? GetOwnedItem(ulong discordId, Guid itemId)
        {
            var ownedItem =
                _db.OwnedInventoryItems
                .Include(o => o.Inventory.UserProfile)
                .Include(o => o.Item)
                .FirstOrDefault(o => o.Inventory.UserProfile.DiscordId == discordId && o.Item.Id == itemId);
            
            return ownedItem;
        }

        public OwnedItem GetOrCreateOwnedItem(ulong discordId, string itemId)
            => GetOrCreateOwnedItem(discordId, new Guid(itemId));

        public OwnedItem GetOrCreateOwnedItem(ulong discordId, Guid itemId)
        {
            var ownedItem = GetOwnedItem(discordId, itemId);
            ownedItem ??= CreateOwnedItem(discordId, itemId);
            return ownedItem;
        }

        public OwnedItem ModifyOwnedItem(ulong discordId, string itemId, Action<OwnedItem> action)
            => ModifyOwnedItem(discordId, new Guid(itemId), action);

        public OwnedItem ModifyOwnedItem(ulong discordId, Guid itemId, Action<OwnedItem> action)
        {
            var ownedItem = GetOrCreateOwnedItem(discordId, itemId);
            action(ownedItem);
            _db.SaveChanges();

            return ownedItem;
        }

        public OwnedItem CreateOwnedItem(ulong discordId, string itemId)
            => CreateOwnedItem(discordId, new Guid(itemId));

        public OwnedItem CreateOwnedItem(ulong discordId, Guid itemId)
        {
            var baseItem = GetItem(itemId);

            if (baseItem == null)
                throw new Exception($"Item `{itemId}` not found");

            var ownedItem = GetOwnedItem(discordId, itemId);
            if (ownedItem == null)
            {
                var inventory = GetInventory(discordId);
                ownedItem = new OwnedItem
                {
                    Inventory = inventory,
                    Item = baseItem,
                    Quantity = 0,
                };
                inventory.OwnedItems.Add(ownedItem);
                _db.SaveChanges();
            }
            return ownedItem;
        }

        public IEnumerable<Item> GetAllItems()
        {
            List<Item> items = new List<Item>();
            items.AddRange(_db.DiscordAwards);

            return items;
        }

        public Item? GetItem(string itemId)
            => GetItem(new Guid(itemId));

        public Item? GetItem(Guid itemId)
        {
            return
                GetAllItems()
                .FirstOrDefault(i => i.Id == itemId);
        }
    }
}
