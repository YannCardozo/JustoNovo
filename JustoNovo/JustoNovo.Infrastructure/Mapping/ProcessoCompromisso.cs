using JustoNovo.Domain.ProcessosEntidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustoNovo.Infrastructure.Mapping
{
    public class ProcessoCompromisso : IEntityTypeConfiguration<ProcessosCompromissos>
    {
        public void Configure(EntityTypeBuilder<ProcessosCompromissos> builder)
        {

            // Tabela
            builder.ToTable("ProcessosCompromissos");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_ProcessosCompromissos");

            //entidadebase

            builder
                .Property(o => o.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                .HasColumnType("int");
            //            public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public DateTime  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public DateTime  { get; set; }
            //public int  { get; set; }
            //public Processo Processo { get; set; }

            builder
                .Property(o => o.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder
                .Property(o => o.NomeAdvogado)
                .HasColumnName("NomeAdvogado")
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder
                .Property(o => o.NomeCliente)
                .HasColumnName("NomeCliente")
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder
                .Property(o => o.Data)
                .HasColumnName("Data")
                .HasColumnType("datetime2");

            builder
                .Property(o => o.Obs)
                .HasColumnName("Obs")
                .HasColumnType("varchar")
                .HasMaxLength(400);

            builder
                .Property(o => o.Local)
                .HasColumnName("Local")
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder
                .Property(o => o.Prioridade)
                .HasColumnName("Prioridade")
                .HasColumnType("varchar")
                .HasMaxLength(30);

            builder
                .Property(o => o.Status)
                .HasColumnName("Status")
                .HasColumnType("varchar")
                .HasMaxLength(30);

            builder
                .Property(o => o.DataProximoEvento)
                .HasColumnName("DataProximoEvento")
                .HasColumnType("datetime2");

            builder
                .Property(o => o.ProcessoId)
                .HasColumnName("ProcessoId")
                .HasColumnType("int");


            builder
                .HasOne(p => p.Processo)
                .WithMany()
                .HasForeignKey(pa => pa.ProcessoId);

            //entidadebase

            builder
                .Property(o => o.DataCadastro)
                .HasColumnName("DataCadastro")
                .HasColumnType("datetime2");

            builder
                .Property(o => o.DataAtualizacao)
                    .HasColumnName("DataAtualizacao")
                    .HasColumnType("datetime2");

            builder
                .Property(o => o.CadastradoPor)
                    .HasColumnName("CadastradoPor")
                    .HasColumnType("int");

            builder
                .Property(o => o.AtualizadoPor)
                    .HasColumnName("AtualizadoPor")
                    .HasColumnType("int");
        }
    }
}
