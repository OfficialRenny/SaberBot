using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Saber.Database.Models;
using Saber.Database.Models.Guilds;
using Saber.Database.Models.Items;
using Saber.Database.Models.Profile;
using Saber.Database.Models.Site;

namespace Saber.Database;

public class Db : IdentityDbContext<ApplicationUser>
{
    public Db(DbContextOptions<Db> options) : base(options)
    {
    }

    public DbSet<Guild> Guilds { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<CommandPrefix> CommandPrefixes { get; set; }
    public DbSet<CachedFileUpload> CachedFileUploads { get; set; }

    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<OwnedItem> OwnedInventoryItems { get; set; }

    public DbSet<ShopItem> ShopItems { get; set; }
    public DbSet<DiscordAward> DiscordAwards { get; set; }

    public DbSet<OneLinerQuote> OneLiners { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}