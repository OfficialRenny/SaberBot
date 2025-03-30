using NetCord;
using NetCord.Gateway;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;
using Saber.Bot.Core.Extensions;

namespace Saber.Bot.Commands.Attributes;

public class ListeningActivityAutocompleteHandler : IAutocompleteProvider<AutocompleteInteractionContext>
{
    public async ValueTask<IEnumerable<ApplicationCommandOptionChoiceProperties>?> GetChoicesAsync(ApplicationCommandInteractionDataOption option, AutocompleteInteractionContext context)
    {
        var userPresences = context.Guild?.Presences
            .Select(x => x.Value).Where(x => x.User.Id == context.User.Id).ToList();

        if (userPresences == null || userPresences.Count == 0)
            return [];
        
        var musicPresences = userPresences.SelectMany(x => x.Activities).Where(x => x.Type == UserActivityType.Listening).ToList();

        var presences = musicPresences.Select(x =>
            new ApplicationCommandOptionChoiceProperties(x.Name, x.GetApplicationId().ToString())).ToList();
        
        if (presences.All(x => x.Name != "Spotify"))
            presences.Insert(0, new ApplicationCommandOptionChoiceProperties("Spotify", UserActivityExtensions.HardCodedApplicationIds["Spotify"].ToString()));
        
        return presences;
    }
}