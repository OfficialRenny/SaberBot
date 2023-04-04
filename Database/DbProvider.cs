using Microsoft.EntityFrameworkCore;
using SaberBot.Core;
using SaberBot.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberBot.Database
{
    public class DbProvider
    {
        private readonly Db _db;

        public DbProvider(Db db)
        {
            _db = db;
        }

        public void SaveChanges()
            => _db.SaveChanges();

        public UserProfile GetOrCreateUserProfile(Discord.IUser user)
            => GetOrCreateUserProfile(user.Id);

        // get or create a user profile
        public UserProfile GetOrCreateUserProfile(ulong userId)
        {
            var profile = _db.UserProfiles.Include(x => x.Inventory).FirstOrDefault(u => u.DiscordId == userId);
            if (profile == null)
            {
                var inv = new Inventory
                {
                    Currency = Config.StarterCurrency,
                };
                profile = new UserProfile
                {
                    DiscordId = userId,
                    Inventory = inv,
                };
                inv.UserProfile = profile;

                _db.UserProfiles.Add(profile);
                _db.SaveChanges();
            }
            return profile;
        }

        // get or create a command prefix
        public CommandPrefix GetOrCreateCommandPrefix(ulong guildId)
        {
            var prefix = _db.CommandPrefixes.FirstOrDefault(p => p.GuildId == guildId);
            if (prefix == null)
            {
                prefix = new CommandPrefix { GuildId = guildId };
                _db.CommandPrefixes.Add(prefix);
                _db.SaveChanges();
            }
            return prefix;
        }
    }
}
