using Discord;
using Saber.Database.Models.Guilds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Database.Providers
{
    public class GuildProvider : GenericProvider<Guild>
    {
        public GuildProvider(Db db) : base(db)
        {
        }

        public Guild? GetGuild(ulong id)
        {
            return DbCtx.Guilds.FirstOrDefault(x => x.GuildId == id);
        }

        public Guild CreateGuild(IGuild guild)
            => CreateGuild(guild.Id, guild.Name);

        public Guild CreateGuild(ulong id, string name = "")
        {
            var guild = GetGuild(id);
            if (guild != null)
                return guild;
            

            guild = new Guild
            {
                GuildId = id,
                Name = name,
            };
            Add(guild);
            Save();

            return guild;
        }
    }
}
