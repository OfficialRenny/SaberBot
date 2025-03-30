using NetCord.Gateway;

namespace Saber.Common.Services.Models;

public class RichPresenceListeningTracking
{
    public ulong TrackedApplicationId { get; set; }
    public Presence LastPresence { get; set; }
    public DateTime LastUpdate { get; set; }
    
    public SlidingBuffer<string> LastSubscribedActivities { get; set; } = new(5);
    public ICollection<ulong> SubscribedChannels { get; set; } = new List<ulong>();
    public ThrottledCall ThrottledMessageCall { get; set; } = new(5000);
}