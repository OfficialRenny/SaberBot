using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Saber.Common;

namespace Saber.Database;

public class DbFactory : IDesignTimeDbContextFactory<Db>, IDbContextFactory<Db>
{
    public Db CreateDbContext()
    {
        var config = new Config();

        var optionsBuilder = new DbContextOptionsBuilder<Db>();
        optionsBuilder.UseSqlServer(config["Database:ConnectionString"]);

        return new Db(optionsBuilder.Options);
    }

    public Db CreateDbContext(string[] args)
    {
        return CreateDbContext();
    }
}