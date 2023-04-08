using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberBot.Database.Models.Guilds
{
    public class Guild
    {
        [Key]
        public Guid Id { get; set; }

        public ulong GuildId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Prefix { get; set; } = ";";
    }
}
