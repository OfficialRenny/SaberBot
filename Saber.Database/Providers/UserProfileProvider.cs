using Microsoft.EntityFrameworkCore;
using NetCord;
using Saber.Common.Extensions;
using Saber.Database.Models.Profile;

namespace Saber.Database.Providers;

public class UserProfileProvider : GenericProvider<UserProfile>
{
    public UserProfileProvider(Db db) : base(db)
    {
    }

    public UserProfile? GetUserProfile(User user)
    {
        return GetUserProfile(user.Id);
    }

    public UserProfile? GetUserProfile(ulong discordId)
    {
        var profile =
            DbCtx.UserProfiles
                .Include(x => x.Inventory)
                .FirstOrDefault(u => u.DiscordId == discordId);

        return profile;
    }

    public UserProfile CreateProfile(User user)
    {
        return CreateProfile(user.Id, user.GetDisplayName());
    }

    public UserProfile CreateProfile(ulong discordId, string username = "")
    {
        var profile = new UserProfile
        {
            DiscordId = discordId
        };
        if (!string.IsNullOrEmpty(username))
            profile.LastKnownDisplayName = username;
        DbCtx.UserProfiles.Add(profile);
        DbCtx.SaveChanges();
        return profile;
    }

    public UserProfile GetOrCreateProfile(User user)
    {
        return GetOrCreateProfile(user.Id, user.GetDisplayName());
    }

    public UserProfile GetOrCreateProfile(ulong discordId, string username = "")
    {
        var profile = GetUserProfile(discordId);
        profile ??= CreateProfile(discordId, username);
        return profile;
    }

    public UserProfile ModifyUserProfile(User user, Action<UserProfile> action)
    {
        return ModifyUserProfile(user.Id, action);
    }

    public UserProfile ModifyUserProfile(ulong discordId, Action<UserProfile> action)
    {
        var profile = GetOrCreateProfile(discordId);
        return ModifyUserProfile(profile, action);
    }

    public UserProfile ModifyUserProfile(UserProfile profile, Action<UserProfile> action)
    {
        action(profile);
        DbCtx.SaveChanges();
        return profile;
    }
}