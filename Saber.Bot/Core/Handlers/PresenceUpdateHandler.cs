using NetCord.Gateway;
using NetCord.Hosting.Gateway;
using Saber.Common.Services;

namespace Saber.Bot.Core.Handlers;

[GatewayEvent(nameof(GatewayClient.PresenceUpdate))]
public class PresenceUpdateHandler(RichPresenceListeningTrackingService musicTrackingService) : IGatewayEventHandler<Presence>
{
    public async ValueTask HandleAsync(Presence arg)
    {
        if (arg.User.IsBot || arg.User.IsSystemUser == true)
            return;

        Task[] tasks = [
            musicTrackingService.HandlePresenceUpdate(arg),
        ];
        
        await Task.WhenAll(tasks);
    }
}