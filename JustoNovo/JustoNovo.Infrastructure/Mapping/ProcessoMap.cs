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
    public class ProcessoMap : IEntityTypeConfiguration<Processo>
    {
        public void Configure(EntityTypeBuilder<Processo> builder)
        {
            // Tabela
            builder.ToTable("Processos");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_Processo");

            //entidadebase

            builder
                .Property(o => o.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                .HasColumnType("int");


            builder
                .Property(o => o.CodPJEC)
                .HasColumnName("CodPJEC")
                .HasColumnType("varchar")
                .HasMaxLength(30);

            builder
                .Property(o => o.ObsProcesso)
                .HasColumnName("ObsProcesso")
                .HasColumnType("varchar")
                .HasMaxLength(400)
                .IsRequired(false);

            builder
                .Property(o => o.DataFim)
                .HasColumnName("DataFim")
                .HasColumnType("datetime2")
                .IsRequired(false);

            builder
                .Property(o => o.MeioDeComunicacao)
                .HasColumnName("MeioDeComunicacao")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(false);

            builder
                .Property(o => o.MeioDeComunicacaoData)
                .HasColumnName("MeioDeComunicacaoData")
                .HasColumnType("datetime2")
                .IsRequired(false);

            builder
                .Property(o => o.Prazo)
                .HasColumnName("Prazo")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(false);

            builder
                .Property(o => o.ProximoPrazo)
                .HasColumnName("ProximoPrazo")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(false);

            builder
                .Property(o => o.ProximoPrazoData)
                .HasColumnName("ProximoPrazoData")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(false);

            builder
                .Property(o => o.PJECAcao)
                .HasColumnName("PJECAcao")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(false);

            builder
                .Property(o => o.UltimaMovimentacaoProcessual)
                .HasColumnName("UltimaMovimentacaoProcessual")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(false);

            builder
                .Property(o => o.UltimaMovimentacaoProcessualData)
                .HasColumnName("UltimaMovimentacaoProcessualData")
                .HasColumnType("datetime2")
                .IsRequired(false);

            builder
                .Property(o => o.AdvogadaCiente)
                .HasColumnName("AdvogadaCiente")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(false);

            builder
                .Property(o => o.Comarca)
                .HasColumnName("Comarca")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired(false);

            builder
                .Property(o => o.OrgaoJulgador)
                .HasColumnName("OrgaoJulgador")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired(false);

            builder
                .Property(o => o.Competencia)
                .HasColumnName("Competencia")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired(false);

            builder
                .Property(o => o.MotivosProcesso)
                .HasColumnName("MotivosProcesso")
                .HasColumnType("varchar")
                .HasMaxLength(300)
                .IsRequired(false);

            builder
                .Property(o => o.SegredoJustica)
                .HasColumnName("SegredoJustica")
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsRequired(false);


            builder
                .Property(o => o.JusGratis)
                .HasColumnName("JusGratis")
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsRequired(false);

            builder
                .Property(o => o.TutelaLiminar)
                .HasColumnName("TutelaLiminar")
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsRequired(false);

            builder
                .Property(o => o.Prioridade)
                .HasColumnName("Prioridade")
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsRequired(false);

            builder
                .Property(o => o.Autuacao)
                .HasColumnName("Autuacao")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired(false);

            builder
                .Property(o => o.TituloProcesso)
                .HasColumnName("TituloProcesso")
                .HasColumnType("varchar")
                .HasMaxLength(300)
                .IsRequired(false);

            builder
                .Property(o => o.PartesProcesso)
                .HasColumnName("PartesProcesso")
                .HasColumnType("varchar")
                .HasMaxLength(300)
                .IsRequired(false);

            builder
                .Property(o => o.ValorDaCausa)
                .HasColumnName("ValorDaCausa")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(false);

            builder
                .Property(o => o.DataAbertura)
                .HasColumnName("DataAbertura")
                .HasColumnType("datetime2");

            //public Polo? PoloAtivo { get; set; }
            //public Polo? PoloPassivo { get; set; }

            builder
                .Property(o => o.AdvogadoId)
                .HasColumnName("AdvogadoId")
                .HasColumnType("int");

            builder
               .HasMany(x => x.ProcessosCompromissos)
               .WithOne(x => x.Processo);

            builder
                .HasMany(p => p.ProcessosAtualizacoes)
                .WithOne()
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
