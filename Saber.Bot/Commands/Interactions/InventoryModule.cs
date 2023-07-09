using Discord;
using Discord.Interactions;
using Saber.Bot.Commands.Attributes;
using Saber.Common.Services;
using Saber.Database;
using Saber.Database.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Commands.Interactions
{
    [Group("inv", "Your SaberBot Inventory")]
    public class InventoryModule : InteractionModuleBase<SocketInteractionContext>
    {
        private readonly UserProfileProvider _userProfileProvider;
        private readonly ItemService _itemService;

        public InventoryModule(UserProfileProvider userProfileProvider, ItemService itemService)
        {
            _userProfileProvider = userProfileProvider;
            _itemService = itemService;
        }

        [SlashCommand("list", "List all items in your inventory.")]
        public async Task List()
        {
            await DeferAsync();

            var items = _itemService.GetOwnedItems(Context.User.Id);

            var embed = new EmbedBuilder()
                .WithTitle($"{Context.User.Username}'s Inventory")
                .WithColor(Color.Blue)
                .WithDescription($"You have {items.Count()} items in your inventory.");

            foreach (var item in items)
            {
                embed.AddField($"{item.Item.Name}", $"{item.Quantity}x Owned", true);
            }

            await FollowupAsync(embed: embed.Build());
        }

        [SlashCommand("give", "Gift a user a Discord Award/Item from your inventory.")]
        public async Task Give(
            IUser user,
            [Summary("Item", "The item you want to gift to the user.")]
            [Autocomplete(typeof(OwnedItemsAutocompleteHandler))] 
            string itemId,
            [Summary("Quantity", "The quantity of the item you want to gift to the user.")]
            [MinValue(1)]
            int quantity = 1,
            bool notifyRecipient = true)
        {
            var d = DeferAsync(true);
            var userProfile = _userProfileProvider.GetUserProfile(Context.User.Id);
            
            var baseItem = _itemService.GetItem(itemId);
            if (baseItem == null)
            {
                await d;
                await FollowupAsync($"That item does not exist.");
                return;
            }

            var ownedItem = _itemService.GetOrCreateOwnedItem(userProfile.DiscordId, baseItem.Id);
            if (ownedItem.Quantity < quantity)
            {
                await d;
                await FollowupAsync($"You don't have enough of this award to gift it.");
                return;
            }

            var recipientProfile = _userProfileProvider.GetUserProfile(user.Id);
            if (recipientProfile == null)
            {
                await d;
                await FollowupAsync($"That is not a valid user.");
                return;
            }

            _itemService.ModifyOwnedItem(userProfile.DiscordId, baseItem.Id, (item) => item.Quantity -= quantity);
            _itemService.ModifyOwnedItem(recipientProfile.DiscordId, baseItem.Id, (item) => item.Quantity += quantity);

            await d;
            await FollowupAsync($"You have gifted {quantity}x {baseItem.Name} to {user.Username}.");

            if (notifyRecipient)
            {
                var embed = new EmbedBuilder()
                    .WithColor(Color.Green)
                    .WithTitle("You have received a gift!")
                    .WithDescription($"You have received {quantity}x {baseItem.Name} from {Context.User.Username}.");
                if (!string.IsNullOrEmpty(baseItem.ImageUrl))
                    embed.WithImageUrl(baseItem.ImageUrl);

                await user.SendMessageAsync(embed: embed.Build());
            }
        }

        [SlashCommand("buy", "Buy an item from the shop.")]
        public Task Buy(
            [Summary("Item", "The item you want to buy from the shop.")]
            [Autocomplete(typeof(ShopItemsAutocompleteHandler))]
            string itemId,
            int quantity = 1)
        {
            var d = DeferAsync(true);

            var userProfile = _userProfileProvider.GetUserProfile(Context.User.Id);
            var item = _itemService.GetShopItem(itemId);

            if (item == null)
            {
                FollowupAsync($"That item does not exist.");
                return Task.CompletedTask;
            }

            if (item.Price * quantity > userProfile.Inventory.Currency)
            {
                FollowupAsync($"You don't have enough points to buy this item.");
                return Task.CompletedTask;
            }

            userProfile.Inventory.Currency -= item.Price * quantity;
            var ownedItem = _itemService.ModifyOwnedItem(userProfile.DiscordId, item.Item.Id, item => item.Quantity += quantity);

            var embed = new EmbedBuilder()
                .WithColor(Color.Green)
                .WithTitle("You have bought an item!")
                .WithDescription($"You have bought {quantity}x {item.Item.Name} from the shop for {item.Price * quantity} points. You now own {ownedItem.Quantity}x {ownedItem.Item.Name}.");
            if (!string.IsNullOrEmpty(item.Item.ImageUrl))
                embed.WithImageUrl(item.Item.ImageUrl);

            return FollowupAsync(embed: embed.Build());
        }
    }
}
