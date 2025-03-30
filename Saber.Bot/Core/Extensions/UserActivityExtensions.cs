using NetCord.Gateway;

namespace Saber.Bot.Core.Extensions;

public static class UserActivityExtensions
{
    // some made up application ids, just so we at least something
    public static readonly Dictionary<string, ulong> HardCodedApplicationIds = new()
    {
        { "Spotify", ulong.MaxValue - 1 }, 
    };
    
    public static ulong GetApplicationId(this UserActivity activity)
    {
        if (activity.ApplicationId != null)
            return activity.ApplicationId.Value;
        
        if (HardCodedApplicationIds.TryGetValue(activity.Name, out var applicationId))
            return applicationId;

        return 0;
    }
}