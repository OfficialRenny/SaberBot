using NetCord;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;
using Saber.Common.Services;

namespace Saber.Bot.Commands.Attributes;

public class ShopItemsAutocompleteHandler(ItemService itemService)
    : IAutocompleteProvider<AutocompleteInteractionContext>
{
    public async ValueTask<IEnumerable<ApplicationCommandOptionChoiceProperties>?> GetChoicesAsync(
        ApplicationCommandInteractionDataOption option, AutocompleteInteractionContext context)
    {
        var shopItems = itemService.GetShopItems();

        IEnumerable<ApplicationCommandOptionChoiceProperties> suggestions =
            shopItems
                .Where(x => option.Value == null ||
                            x.Item.Name.Contains(option.Value, StringComparison.OrdinalIgnoreCase))
                .Select(x =>
                    new ApplicationCommandOptionChoiceProperties($"{x.Item.Name} - {x.Price}c", x.Id.ToString()))
                .ToList();

        return suggestions.Any() ? suggestions.Take(25) : [];
    }
}