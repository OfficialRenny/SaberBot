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
    public class ShopItemsAutocompleteHandler : AutocompleteHandler
    {
        public override async Task<AutocompletionResult> GenerateSuggestionsAsync(IInteractionContext context, IAutocompleteInteraction autocompleteInteraction, IParameterInfo parameter, IServiceProvider services)
        {
            var itemService = services.GetRequiredService<ItemService>();

            var shopItems = itemService.GetShopItems();

            IEnumerable<AutocompleteResult> suggestions = shopItems.Select(x => new AutocompleteResult($"{x.Item.Name} - {x.Price}c", x.Id.ToString())).ToList();

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
