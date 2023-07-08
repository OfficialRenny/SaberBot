using Discord;
using Discord.Interactions;
using Microsoft.Extensions.DependencyInjection;
using Saber.Common.Services;
using Saber.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Bot.Commands.Attributes
{
    public class OwnedItemsAutocompleteHandler : AutocompleteHandler
    {
        public override async Task<AutocompletionResult> GenerateSuggestionsAsync(IInteractionContext context, IAutocompleteInteraction autocompleteInteraction, IParameterInfo parameter, IServiceProvider services)
        {
            var itemService = services.GetRequiredService<ItemService>();

            // get all inventory items owned by user, return an autocompleteresult list with the item names as names, and their database ids as values
            var items = itemService.GetOwnedItems(context.User.Id);

            IEnumerable<AutocompleteResult> suggestions = items.Select(x => new AutocompleteResult(x.Item.Name, x.Item.Id.ToString())).ToList();

            if (suggestions.Any())
            {
                return AutocompletionResult.FromSuccess(suggestions.Take(25));
            }
            else
            {
                return AutocompletionResult.FromSuccess();
            }
        }
    }
}
