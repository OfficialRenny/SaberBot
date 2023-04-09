using Discord;
using Discord.Interactions;
using SaberBot.Commands.Attributes;
using SaberBot.Core.Services;
using SaberBot.Database;
using SaberBot.Database.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberBot.Commands.Interactions
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

            var ownedItem = _itemService.GetOwnedItem(userProfile.DiscordId, baseItem.Id);
            if (ownedItem.Quantity < quantity)
            {
                await d;
                await FollowupAsync($"You don't have enough of this award to gift it.");
                return;
            }

            var recipientProfile = _userProfileProvider.GetUserProfile(user.Id);
            var recipientOwnedItem = _itemService.GetOwnedItem(recipientProfile.DiscordId, baseItem.Id);

            ownedItem.Quantity -= quantity;
            recipientOwnedItem.Quantity += quantity;

            _userProfileProvider.DbCtx.SaveChanges();

            await d;
            await FollowupAsync($"You have gifted {quantity}x {baseItem.Name} to {user.Username}.");
        }
    }
}
