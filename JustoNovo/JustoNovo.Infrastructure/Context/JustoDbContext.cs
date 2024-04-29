using JustoNovo.Domain.ProcessosEntidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Diagnostics.Metrics;

namespace JustoNovo.Infrastructure.Context
{
    public class JustoDbContext : DbContext
    {
        public JustoDbContext(DbContextOptions<JustoDbContext> options) : base(options)
        {
        }


        //dbset
        public DbSet<Advogado> Advogados { get; set; }
        public DbSet<AdvogadoEspecialidade> Advogados_Especialidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Processo> Processos { get; set; }
        public DbSet<ProcessosAtualizacao> Processos_Atualizacoes { get; set; }
        public DbSet<ProcessosCompromissos> Processos_Compromissos { get; set; }
        public DbSet<SiteContato> Site_Contatos { get; set; }
        public DbSet<Polo> PolosPartes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Server = localhost\\SQLEXPRESS; Database = FundamentosBlazorServer; Trusted_Connection = True; TrustServerCertificate = true;
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database = JustoTeste; Trusted_Connection = True; TrustServerCertificate = true");
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\DESKTOP-QTOET89\\SQLEXPRESS;Initial Catalog=JustoTeste;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(JustoDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
