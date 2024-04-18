﻿using JustoNovo.Domain.ProcessosEntidades;
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
        public DbSet<AdvogadoEspecialidade> Advogados_Especialidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Processo> Processos { get; set; }
        public DbSet<ProcessosAtualizacao> Processos_Atualizacoes { get; set; }
        public DbSet<ProcessosCompromissos> Processos_Compromissos { get; set; }
        public DbSet<ProcessosDespesa> Processos_Despesas { get; set; }
        public DbSet<SiteContato> Site_Contatos { get; set; }

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
