using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberBot.Database.Models
{
    [Index(nameof(GuildId), IsUnique = true)]
    public class CommandPrefix
    {
        [Key]
        public int Id { get; set; }

        public ulong GuildId { get; set; }

        public string Prefix { get; set; } = ";";
    }
}
