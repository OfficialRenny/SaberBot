using Microsoft.EntityFrameworkCore;
using Saber.Database.Models;
using Saber.Database.Models.Guilds;
using Saber.Database.Models.Items;
using Saber.Database.Models.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saber.Common;
using Microsoft.Extensions.Configuration;

namespace Saber.Database
{
    public class Db : DbContext
    {
        internal readonly IConfiguration Config;

        public DbSet<Guild> Guilds { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<CommandPrefix> CommandPrefixes { get; set; }
        public DbSet<CachedFileUpload> CachedFileUploads { get; set; }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<OwnedItem> OwnedInventoryItems { get; set; }

        public DbSet<ShopItem> ShopItems { get; set; }
        public DbSet<DiscordAward> DiscordAwards { get; set; }


        public Db(IConfiguration config) : base()
        {
            Config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Config["Database:ConnectionString"]);
        }
    }
}
