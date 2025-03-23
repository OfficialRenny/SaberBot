using Microsoft.Extensions.DependencyInjection;
using Saber.Common.Services;
using Saber.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCord;
using NetCord.Rest;
using NetCord.Services;
using NetCord.Services.ApplicationCommands;

namespace Saber.Bot.Commands.Attributes
{
    public class ShopItemsAutocompleteHandler(ItemService itemService) : IAutocompleteProvider<AutocompleteInteractionContext>
    {
        public async ValueTask<IEnumerable<ApplicationCommandOptionChoiceProperties>?> GetChoicesAsync(ApplicationCommandInteractionDataOption option, AutocompleteInteractionContext context)
        {
            var shopItems = itemService.GetShopItems();

            IEnumerable<ApplicationCommandOptionChoiceProperties> suggestions = shopItems.Select(x => new ApplicationCommandOptionChoiceProperties($"{x.Item.Name} - {x.Price}c", x.Id.ToString())).ToList();

            return suggestions.Any() ? suggestions.Take(25) : [];
        }
    }
}
