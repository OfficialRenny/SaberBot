using Microsoft.EntityFrameworkCore;
using SaberBot.Database.Models;
using SaberBot.Database.Models.Guilds;
using SaberBot.Database.Models.Items;
using SaberBot.Database.Models.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberBot.Database
{
    public class Db : DbContext
    {
        public DbSet<Guild> Guilds { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<CommandPrefix> CommandPrefixes { get; set; }
        public DbSet<CachedFileUpload> CachedFileUploads { get; set; }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<OwnedItem> OwnedInventoryItems { get; set; }

        public DbSet<ShopItem> ShopItems { get; set; }
        public DbSet<DiscordAward> DiscordAwards { get; set; }


        public Db() : base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Core.Config.ConnectionString);
        }
    }
}
