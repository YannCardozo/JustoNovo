using JustoNovo.Domain.ProcessosEntidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustoNovo.Infrastructure.Mapping
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            // Tabela
            builder.ToTable("Enderecos");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_Endereco");

            //entidadebase

            builder
                .Property(o => o.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                .HasColumnType("int");

            builder
                .Property(o => o.Rua)
                .HasColumnName("Rua")
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder
                .Property(o => o.Numero)
                .HasColumnName("Numero")
                .HasColumnType("varchar")
                .HasMaxLength(10);

            builder
                .Property(o => o.Bairro)
                .HasColumnName("Bairro")
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder
                .Property(o => o.Municipio)
                .HasColumnName("Municipio")
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder
                .Property(o => o.UF)
                .HasColumnName("UF")
                .HasColumnType("varchar")
                .HasMaxLength(3);

            builder
                .Property(o => o.Cep)
                .HasColumnName("Cep")
                .HasColumnType("varchar")
                .HasMaxLength(15);

            builder
                .Property(o => o.Referencia)
                .HasColumnName("Referencia")
                .HasColumnType("varchar")
                .HasMaxLength(80);

            builder
                .HasOne(o => o.EnderecoCliente)
                .WithOne(o => o.Endereco)
                .IsRequired(false);

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
