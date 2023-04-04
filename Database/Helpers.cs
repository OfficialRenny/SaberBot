using SaberBot.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberBot.Database
{
    public class Helpers
    {
        public static string GetCommandPrefix(ulong guildId, Db DbCtx = null)
        {
            CommandPrefix commandPrefix = DbCtx.CommandPrefixes.FirstOrDefault(n => n.GuildId == guildId);
            if (commandPrefix == null)
            {
                commandPrefix = new CommandPrefix { GuildId = guildId };
                DbCtx.CommandPrefixes.Add(commandPrefix);
                DbCtx.SaveChanges();
            }
            return commandPrefix.Prefix;
        }

        public static UserProfile GetUserProfile(ulong discordId, Db DbCtx = null)
        {
            UserProfile userProfile = DbCtx.UserProfiles.FirstOrDefault(n => n.DiscordId == discordId);
            if (userProfile == null)
            {
                userProfile = new UserProfile { DiscordId = discordId };
                DbCtx.UserProfiles.Add(userProfile);
                DbCtx.SaveChanges();
            }
            return userProfile;
        }
    }
}
