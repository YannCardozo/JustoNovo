using JustoNovo.Domain.ProcessosEntidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustoNovo.Infrastructure.Mapping
{
    public class ProcessoAtualizacaoMap : IEntityTypeConfiguration<ProcessosAtualizacao>
    {
        public void Configure(EntityTypeBuilder<ProcessosAtualizacao> builder)
        {
            // Tabela
            builder.ToTable("ProcessosAtualizacao");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_ProcessosAtualizacao");

            //falta mapear atributos e chaves estrangeiras

            //entidadebase

            builder
                //precisa do identity? para associar o cliente a  tabela de usuarios login
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
                    .Property(o => o.ConteudoAtualizacao)
                    .HasColumnName("ConteudoAtualizacao")
                    .HasColumnType("varchar")
                    .HasMaxLength(400)
                    .IsRequired(false);

                builder
                    .Property(o => o.TituloMovimento)
                    .HasColumnName("TituloMovimento")
                    .HasColumnType("varchar")
                    .HasMaxLength(100);

                builder
                    .Property(o => o.DataMovimentacao)
                    .HasColumnName("DataMovimentacao")
                    //.HasColumnType("datetime2")
                    .IsRequired(false);

                builder
                    .Property(o => o.ProcessoId)
                    .HasColumnName("ProcessoId")
                    .HasColumnType("int");


                builder
                    .HasOne(pa => pa.Processo) // Propriedade de navegação para Processo
                    .WithMany(p => p.ProcessosAtualizacoes) // Propriedade de navegação para ProcessosAtualizacao em Processo
                    .HasForeignKey(pa => pa.ProcessoId); // Chave estrangeira ProcessoId
            

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
