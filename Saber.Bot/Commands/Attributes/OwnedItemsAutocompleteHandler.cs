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
    public class OwnedItemsAutocompleteHandler(ItemService itemService) : IAutocompleteProvider<AutocompleteInteractionContext>
    {
        public async ValueTask<IEnumerable<ApplicationCommandOptionChoiceProperties>> GetChoicesAsync(ApplicationCommandInteractionDataOption option, AutocompleteInteractionContext context)
        {
            // get all inventory items owned by user, return an autocompleteresult list with the item names as names, and their database ids as values
            var items = itemService.GetOwnedItems(context.User.Id);

            IEnumerable<ApplicationCommandOptionChoiceProperties> suggestions = items.Select(x => new ApplicationCommandOptionChoiceProperties(x.Item.Name, x.Item.Id.ToString())).ToList();

            return suggestions.Any() ? suggestions.Take(25) : [];
        }
    }
}
