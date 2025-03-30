using Google.Apis.YouTube.v3;
using NetCord;
using NetCord.Gateway;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;
using Saber.Bot.Commands.Attributes;
using Saber.Bot.Core.Extensions;
using Saber.Common;
using Saber.Common.Extensions;
using Saber.Common.Services;
using Saber.Common.Services.Interfaces;
using Saber.Database;
using Saber.Database.Models.Profile;

namespace Saber.Bot.Commands.Interactions;

[SlashCommand("rp2yt", "Rich Presence to YouTube Commands")]
public class RichPresenceToYoutubeModule(
    Config config,
    ILogger logger,
    YouTubeService youTubeService,
    RichPresenceListeningTrackingService trackingService,
    Db db)
    : InteractionModule<ApplicationCommandContext>(config, logger)
{
    
    [SubSlashCommand("get", "Does a youtube search for whatever you/someone else is currently listening to.")]
    public async Task Get(User? user = null)
    {
        await DeferAsync();

        user ??= Context.User;

        var userPresence = Context.Client.Cache.Guilds.SelectMany(x => x.Value.Presences)
            .Where(x => x.Value.User.Id == user.Id).Select(x => x.Value).FirstOrDefault();
        if (userPresence == null)
        {
            await FollowupAsync($"Could not get presence status for {user.GetDisplayName()}.");
            return;
        }

        var musicPresences = userPresence.Activities.Where(n => n.Type == UserActivityType.Listening).ToList();
        if (musicPresences.Count == 0)
        {
            await FollowupAsync($"{user.GetDisplayName()} is not listening to anything.");
            return;
        }

        var cur = musicPresences.First();
        var songTitle = "";
        // if (cur is SpotifyGame s)
        //     songTitle = $"{string.Join(", ", s.Artists)} - {s.TrackTitle}";
        // else
        //     songTitle = cur.Details;
        songTitle = $"{cur.Details} - {cur.State}";

        await DoSearch(songTitle);
    }

    [SubSlashCommand("subscribe", "Subscribes to a channel and posts links to your music as your rich presence updates.")]
    public async Task Subscribe(
        [SlashCommandParameter(AutocompleteProviderType = typeof(ListeningActivityAutocompleteHandler))]
        string? applicationId, 
        TextChannel? channel = null)
    {
        if (applicationId == null || !ulong.TryParse(applicationId, out var appId))
        {
            await RespondAsync("Please specify a valid application ID.");
            return;
        }
        
        channel ??= Context.Channel;
        
        if (channel is not TextGuildChannel textChannel)
        {
            await RespondAsync("Please specify a text channel.");
            return;
        }

        await DeferAsync();

        var success = trackingService.SubscribeToChannel(Context.User.Id, channel.Id, appId);
        
        if (success)
        {
            await FollowupAsync($"Subscribed to {textChannel.Name} for updates from {Context.User.GetDisplayName()}.");
        }
        else
        {
            await FollowupAsync($"Already subscribed to {textChannel.Name} for updates from {Context.User.GetDisplayName()}.");
        }
    }
    
    [SubSlashCommand("unsubscribe", "Unsubscribes from a channel and stops posting links to your music as your rich presence updates.")]
    public async Task Unsubscribe(
        [SlashCommandParameter(AutocompleteProviderType = typeof(Rp2YtSubscribedChannelAutocompleteHandler))]
        string channelId)
    {
        await DeferAsync();
        
        if (channelId == "all")
        {
            var unsubscribeAll = trackingService.UnsubscribeAll(Context.User.Id);
            await FollowupAsync(
                $"Unsubscribed from all channels for updates from {Context.User.GetDisplayName()}.");
            return;
        }
        
        if (!ulong.TryParse(channelId, out var channelIdParsed))
        {
            await FollowupAsync("Please specify a valid channel ID.");
            return;
        }
        
        var channel = Context.Client.Cache.Guilds.SelectMany(x => x.Value.Channels)
            .Where(x => x.Value.Id == channelIdParsed).Where(x => x.Value is TextGuildChannel).Select(x => (TextGuildChannel)x.Value).FirstOrDefault();

        if (channel == null && Context.Channel is TextGuildChannel textChannel) 
            channel = textChannel;

        if (channel == null)
        {
            await RespondAsync("Please specify a text channel.");
            return;
        }

        await DeferAsync();

        var success = trackingService.UnsubscribeFromChannel(Context.User.Id, channel.Id);
        
        await FollowupAsync($"Unsubscribed from {channel.Name} for updates from {Context.User.GetDisplayName()}.");
    }
    
    public async Task DoSearch(string? search)
    {
        if (string.IsNullOrWhiteSpace(search))
        {
            await FollowupAsync("Task failed successfully. (Search was empty.)");
            return;
        }

        var resp = await youTubeService.GetSearch(search);

        await FollowupAsync(resp ?? "Task failed successfully. (Couldn't find any search results for some reason...)");
    }

   
}