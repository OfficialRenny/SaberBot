using Discord;
using Microsoft.EntityFrameworkCore;
using Saber.Common;
using Saber.Database.Models.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Database.Providers
{
    public class UserProfileProvider : GenericProvider<UserProfile>
    {
        public UserProfileProvider(Db db) : base(db)
        {
        }

        public UserProfile GetUserProfile(IUser user)
            => GetUserProfile(user.Id);

        public UserProfile GetUserProfile(ulong discordId)
        {
            var profile = 
                DbCtx.UserProfiles
                .Include(x => x.Inventory)
                .FirstOrDefault(u => u.DiscordId == discordId);

            return profile;
        }

        public UserProfile CreateProfile(IUser user)
            => CreateProfile(user.Id, user.GlobalName);

        public UserProfile CreateProfile(ulong discordId, string username = "")
        {
            var profile = new UserProfile
            {
                DiscordId = discordId,
            };
            if (!string.IsNullOrEmpty(username))
                profile.LastKnownDisplayName = username;
            DbCtx.UserProfiles.Add(profile);
            DbCtx.SaveChanges();
            return profile;
        }

        public UserProfile GetOrCreateProfile(IUser user)
            => GetOrCreateProfile(user.Id, user.GlobalName);

        public UserProfile GetOrCreateProfile(ulong discordId, string username = "")
        {
            var profile = GetUserProfile(discordId);
            profile ??= CreateProfile(discordId, username);
            return profile;
        }

        public UserProfile ModifyUserProfile(IUser user, Action<UserProfile> action)
            => ModifyUserProfile(user.Id, action);

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
}
