using JustoNovo.Infrastructure.Context;
using JustoNovo.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace JustoNovo.Infrastructure
{
    public static class ConfigurationModule 
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<JustoDbContext>(x =>
            {
                x.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(Repository<>));

            return services;

        }
    }
}
