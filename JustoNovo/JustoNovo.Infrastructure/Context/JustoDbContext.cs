using Microsoft.EntityFrameworkCore;

namespace JustoNovo.Infrastructure.Context
{
    public class JustoDbContext : DbContext
    {
        public JustoDbContext(DbContextOptions<JustoDbContext> options) : base(options)
        {
        }


        //dbset

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(JustoDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
