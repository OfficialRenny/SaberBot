using NetCord;
using NetCord.JsonModels;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;
using Saber.Bot.Commands.Attributes;
using Saber.Bot.Core.Extensions;
using Saber.Common.Services;
using Saber.Database.Providers;

namespace Saber.Bot.Commands.Interactions;

[SlashCommand("inv", "Your SaberBot Inventory")]
public class InventoryModule(UserProfileProvider userProfileProvider, ItemService itemService)
    : InteractionModule<ApplicationCommandContext>
{
    [SubSlashCommand("list", "List all items in your inventory.")]
    public async Task List()
    {
        await DeferAsync();

        var user = userProfileProvider.GetOrCreateProfile(Context.User.Id);

        var items = itemService.GetOwnedItems(Context.User.Id).ToList();

        var embed = new EmbedProperties
            {
                Title = $"{Context.User.GlobalName}'s Inventory",
                Thumbnail = Context.User.GetAvatarUrl()?.ToString(),
                Color = new Color(0x0000AA),
                Description = $"You have {items.Count} items in your inventory.",
                Fields = new List<EmbedFieldProperties>
                {
                    new EmbedFieldProperties { Name = "Currency:", Value = user.Inventory.Currency.ToString() },
                },
            };
        embed.AddFields(items.Select(item => new EmbedFieldProperties
            { Name = $"{item.Item.Name}", Value = $"{item.Quantity}x Owned", Inline = true }));
        
        var shopItems = itemService.GetShopItems();

        var storeEmbed = new EmbedProperties
        {
            Title = "Shop",
            Color = new Color(0x0000AA),
            Description = "Buy items from the shop.",
            Fields = shopItems.OrderBy(x => x.Price).Select(x => new EmbedFieldProperties
            {
                Name = $"{x.Item.Name}",
                Value = $"{x.Price} points",
                Inline = true
            }).ToArray(),
        };

        await FollowupAsync(new InteractionMessageProperties
        {
            Embeds = new[] { embed, storeEmbed },
        });
    }

    [SubSlashCommand("give", "Gift a user a Discord Award/Item from your inventory.")]
    public async Task Give(
        User user,
        [SlashCommandParameter( Name = "item", Description = "The item you want to gift to the user.", AutocompleteProviderType = typeof(ShopItemsAutocompleteHandler))]
        string itemId,
        [SlashCommandParameter( Name = "quantity", Description = "The quantity of the item you want to gift to the user.", MinValue = 1 )]
        int quantity = 1,
        bool notifyRecipient = true)
    {
        var d = DeferAsync(true);
        var userProfile = userProfileProvider.GetOrCreateProfile(Context.User.Id);
            
        var baseItem = itemService.GetItem(itemId);
        if (baseItem == null)
        {
            await d;
            await FollowupAsync($"That item does not exist.");
            return;
        }

        var ownedItem = itemService.GetOrCreateOwnedItem(userProfile.DiscordId, baseItem.Id);
        if (ownedItem.Quantity < quantity)
        {
            await d;
            await FollowupAsync($"You don't have enough of this award to gift it.");
            return;
        }

        var recipientProfile = userProfileProvider.GetUserProfile(user.Id);
        if (recipientProfile == null)
        {
            await d;
            await FollowupAsync($"That is not a valid user.");
            return;
        }

        itemService.ModifyOwnedItem(userProfile.DiscordId, baseItem.Id, (item) => item.Quantity -= quantity);
        itemService.ModifyOwnedItem(recipientProfile.DiscordId, baseItem.Id, (item) => item.Quantity += quantity);

        await d;
        await FollowupAsync($"You have gifted {quantity}x {baseItem.Name} to {user.Username}.");

        if (notifyRecipient)
        {
            var embed = new EmbedProperties()
                .WithColor(new Color(0x00EE00))
                .WithTitle("You have received a gift!")
                .WithDescription($"You have received {quantity}x {baseItem.Name} from {Context.User.Username}.");
            if (!string.IsNullOrEmpty(baseItem.ImageUrl))
                embed.WithImage(baseItem.ImageUrl);

            await (await user.GetDMChannelAsync()).SendMessageAsync(message: new MessageProperties().WithEmbeds([embed]));
        }
    }

    [SubSlashCommand("buy", "Buy an item from the shop.")]
    public async Task Buy(
        [SlashCommandParameter( Name = "item", Description = "The item you want to buy from the shop.", AutocompleteProviderType = typeof(ShopItemsAutocompleteHandler))]
        string itemId,
        [SlashCommandParameter(MinValue = 1)]
        int quantity = 1)
    {
        await DeferAsync(true);

        var userProfile = userProfileProvider.GetOrCreateProfile(Context.User.Id);
        var item = itemService.GetShopItem(itemId);

        if (item == null)
        {
            await FollowupAsync($"That item does not exist.");
            return;
        }

        if (!item.IsInfinite && item.Stock < quantity)
        {
            await FollowupAsync($"There is not enough stock of this item.");
            return;
        }

        if (item.Price * quantity > userProfile.Inventory.Currency)
        {
            await FollowupAsync($"You don't have enough points to buy this item.");
            return;
        }

        userProfile.Inventory.Currency -= item.Price * quantity;
        userProfileProvider.Save();

        if (!item.IsInfinite)
        {
            itemService.ModifyShopItem(item.Item.Id, item => item.Stock -= quantity);
        }
        var ownedItem = itemService.ModifyOwnedItem(userProfile.DiscordId, item.Item.Id, item => item.Quantity += quantity);

        var embed = new EmbedProperties()
            .WithColor(new Color(0x00EE00))
            .WithTitle("You have bought an item!")
            .WithDescription($"You have bought {quantity}x {item.Item.Name} from the shop for {item.Price * quantity} points. You now own {ownedItem.Quantity}x {ownedItem.Item.Name}.");
        if (!string.IsNullOrEmpty(item.Item.ImageUrl))
            embed.WithImage(item.Item.ImageUrl);

        await FollowupAsync(new InteractionMessageProperties().WithEmbeds([embed]));
    }
}