using JustoNovo.Domain.ProcessosEntidades;
using Microsoft.EntityFrameworkCore;

namespace JustoNovo.Infrastructure.Context
{
    public class JustoDbContext : DbContext
    {
        public JustoDbContext(DbContextOptions<JustoDbContext> options) : base(options)
        {
        }


        //dbset
        public DbSet<Advogado> Advogados { get; set; }
        public DbSet<Advogado_especialidade> Advogados_Especialidades { get; set; }
        public DbSet<Arquivos_cliente_upload> Arquivos_Clientes { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Processos> Processos { get; set; }
        public DbSet<Processos_Atualizacao> Processos_Atualizacoes { get; set; }
        public DbSet<Processos_compromissos> processos_Compromissos { get; set; }
        public DbSet<Processos_Despesa> Processos_Despesas { get; set; }
        public DbSet<Site_contato> Site_Contatos { get; set; }

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
