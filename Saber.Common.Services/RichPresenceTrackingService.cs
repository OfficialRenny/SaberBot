using System.Collections.Concurrent;
using Google.Apis.YouTube.v3;
using NetCord;
using NetCord.Gateway;
using Saber.Common.Extensions;
using Saber.Common.Services.Models;

namespace Saber.Common.Services;

public class RichPresenceListeningTrackingService(GatewayClient client, YouTubeService youTubeService)
{
    private readonly ConcurrentDictionary<ulong, RichPresenceListeningTracking> _richPresenceTracking = new();

    public RichPresenceListeningTracking GetRichPresenceTracking(ulong userId)
    {
        return _richPresenceTracking.GetOrAdd(userId, _ => new RichPresenceListeningTracking());
    }
    
    public bool SubscribeToChannel(ulong userId, ulong channelId, ulong applicationId)
    {
        var tracking = GetRichPresenceTracking(userId);
        if (tracking.TrackedApplicationId != applicationId)
            tracking.SubscribedChannels.Clear();
        
        if (tracking.SubscribedChannels.Contains(channelId)) 
            return false;
        
        tracking.TrackedApplicationId = applicationId;
        tracking.SubscribedChannels.Add(channelId);
        return true;
    }
    
    public bool UnsubscribeAll(ulong userId)
    {
        var tracking = GetRichPresenceTracking(userId);
        if (!tracking.SubscribedChannels.Any()) 
            return false;
        
        tracking.SubscribedChannels.Clear();
        return true;
    }
    
    public bool UnsubscribeFromChannel(ulong userId, ulong channelId)
    {
        var tracking = GetRichPresenceTracking(userId);
        if (!tracking.SubscribedChannels.Contains(channelId)) 
            return false;
        
        tracking.SubscribedChannels.Remove(channelId);
        return true;
    }
    
    public async Task HandlePresenceUpdate(Presence presence)
    {
        var tracking = GetRichPresenceTracking(presence.User.Id);
        tracking.LastPresence = presence;
        tracking.LastUpdate = DateTime.UtcNow;

        if (tracking.SubscribedChannels.Any() && presence.Activities.Any(x => x.Type == UserActivityType.Listening))
        {
            await tracking.ThrottledMessageCall.Run(() =>
            {
                _ = SendListeningPresenceUpdateNotification(presence);
            });
        }
    }
    
    private async Task SendListeningPresenceUpdateNotification(Presence presence)
    {
        var tracking = GetRichPresenceTracking(presence.User.Id);
        if (tracking.SubscribedChannels.Any())
        {
            var activity = presence.Activities.FirstOrDefault(x => x.Type == UserActivityType.Listening);
            if (activity == null)
                return;
            
            var songName = $"{activity.Details} - {activity.State}";
            if (tracking.LastSubscribedActivities.Contains(songName))
                return;
            tracking.LastSubscribedActivities.Add(songName);
            
            var songUrl = await DoSearch(songName);
            if (string.IsNullOrWhiteSpace(songUrl))
                return;
            
            var user = await presence.User.GetAsync();
            var messageTemplate = $"**{user.GetDisplayName()}** is now listening to **{songName}** on **{activity.Name}**.\n{songUrl}";
            
            foreach (var channelId in tracking.SubscribedChannels)
            {
                var channel = client.Cache.Guilds.SelectMany(x => x.Value.Channels)
                    .Where(x => x.Value.Id == channelId).Select(x => x.Value).FirstOrDefault();

                if (channel is TextChannel textChannel)
                {
                    await textChannel.SendMessageAsync(messageTemplate);
                }
            }
        }
    }
    
    private async Task<string> DoSearch(string? search)
    {
        if (string.IsNullOrWhiteSpace(search))
            return string.Empty;

        var listRequest = youTubeService.Search.List("snippet");
        listRequest.MaxResults = 3;
        listRequest.Q = search;
        listRequest.Type = "video";

        var resp = await listRequest.ExecuteAsync();

        return resp.Items.Any()
            ? $"https://youtube.com/watch?v={resp.Items.First().Id.VideoId}"
            : string.Empty;
    }
}