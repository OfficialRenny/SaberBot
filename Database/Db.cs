using Microsoft.EntityFrameworkCore;
using SaberBot.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberBot.Database
{
    public class Db : DbContext
    {
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<CommandPrefix> CommandPrefixes { get; set; }

        public DbSet<ShopItem> ShopItems { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }


        public Db() : base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Core.Config.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserProfile>()
                .HasOne(x => x.Inventory)
                .WithOne(x => x.UserProfile)
                .HasForeignKey<Inventory>(x => x.UserProfileId);
        }
    }
}
