using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Database
{
    public class DbFactory : IDesignTimeDbContextFactory<Db>, IDbContextFactory<Db>
    {
        public Db CreateDbContext(string[] args)
            => CreateDbContext();

        public Db CreateDbContext()
        {
            var config = new Common.Config();

            var optionsBuilder = new DbContextOptionsBuilder<Db>();
            optionsBuilder.UseSqlServer(config["Database:ConnectionString"]);

            return new Db(optionsBuilder.Options);
        }
    }
}
