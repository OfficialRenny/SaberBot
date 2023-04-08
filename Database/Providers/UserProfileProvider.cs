using Discord;
using Microsoft.EntityFrameworkCore;
using SaberBot.Core;
using SaberBot.Database.Models.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberBot.Database.Providers
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
            => CreateProfile(user.Id, user.Username);

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
    }
}
