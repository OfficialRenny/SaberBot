using NetCord;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;
using Saber.Common.Services;

namespace Saber.Bot.Commands.Attributes;

public class WarframeItemAutocompleteHandler(WarframeService warframeService)
    : IAutocompleteProvider<AutocompleteInteractionContext>
{
    public async ValueTask<IEnumerable<ApplicationCommandOptionChoiceProperties>> GetChoicesAsync(
        ApplicationCommandInteractionDataOption option, AutocompleteInteractionContext context)
    {
        var items = warframeService.CachedItems;

        var suggestions =
            items
                .Where(x => option.Value == null ||
                            x.ItemName.Contains(option.Value, StringComparison.InvariantCultureIgnoreCase) ||
                            x.UrlName.Contains(option.Value, StringComparison.InvariantCultureIgnoreCase))
                .Select(x => new ApplicationCommandOptionChoiceProperties(x.ItemName, x.UrlName))
                .ToList();

        return suggestions.Any() ? suggestions.Take(25) : [];
    }
}