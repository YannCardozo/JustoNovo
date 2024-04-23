using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustoNovo.Infrastructure.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<JustoDbContext>
    {
        public JustoDbContext CreateDbContext(string[] args)
        {
            var configurationBuilder = new ConfigurationBuilder();
            //configurationBuilder.AddUserSecrets<DesignTimeDbContextFactory>();

            var config = configurationBuilder.Build();

            var builder = new DbContextOptionsBuilder<JustoDbContext>();
            var connectionString = config.GetConnectionString("Default");
            builder.UseSqlServer(connectionString);

            return new JustoDbContext(builder.Options);

        }
    }
}
