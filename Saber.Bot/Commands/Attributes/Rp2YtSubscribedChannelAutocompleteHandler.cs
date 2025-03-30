using NetCord;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;
using Saber.Common.Services;

namespace Saber.Bot.Commands.Attributes;

public class Rp2YtSubscribedChannelAutocompleteHandler(RichPresenceListeningTrackingService service) : IAutocompleteProvider<AutocompleteInteractionContext>
{
    public async ValueTask<IEnumerable<ApplicationCommandOptionChoiceProperties>?> GetChoicesAsync(ApplicationCommandInteractionDataOption option, AutocompleteInteractionContext context)
    {
        var tracking = service.GetRichPresenceTracking(context.User.Id);
        if (tracking.SubscribedChannels.Count == 0)
            return [];
        
        var channels = GetSubscribedChannelsAsync(context, tracking.SubscribedChannels);
        
        var channelChoices = new List<ApplicationCommandOptionChoiceProperties>();
        await foreach (var channel in channels)
        {
            channelChoices.Add(new ApplicationCommandOptionChoiceProperties(channel.Name, channel.Id.ToString()));
        }
        
        if (channelChoices.Count > 0)
            channelChoices.Insert(0, new ApplicationCommandOptionChoiceProperties("All", "all"));
        
        return channelChoices;
    }
    
    private async IAsyncEnumerable<(string Name, ulong Id)> GetSubscribedChannelsAsync(AutocompleteInteractionContext context, IEnumerable<ulong> channelIds)
    {
        if (context.Channel is not TextGuildChannel textChannel)
            yield break;
        
        var channels = await context.Guild.GetChannelsAsync();
        foreach (var channelId in channelIds)
        {
            var channel = channels.FirstOrDefault(x => x.Id == channelId);
            if (channel != null)
            {
                yield return (channel.Name, channel.Id);
            }
        }
    }
}