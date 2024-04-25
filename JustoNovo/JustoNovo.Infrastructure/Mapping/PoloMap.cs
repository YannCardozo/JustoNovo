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
    public class PoloMap : IEntityTypeConfiguration<Polo>
    {
        public void Configure(EntityTypeBuilder<Polo> builder)
        {
            // Tabela
            builder.ToTable("Polo");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_Polo");

            //falta mapear atributos e chaves estrangeiras

            //entidadebase

            builder
                //precisa do identity? para associar o cliente a  tabela de usuarios login
                .Property(o => o.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                //.UseIdentityColumn()
                .HasColumnType("int");

            builder
                .Property(o => o.NomeParte)
                .HasColumnName("NomeParte")
                .HasColumnType("varchar")
                .HasMaxLength(80);

            builder
                .Property(o => o.TipoParte)
                .HasColumnName("TipoParte")
                .HasColumnType("varchar")
                .HasMaxLength(9)
                .IsRequired(false);

            builder
                .Property(o => o.CPFCNPJParte)
                .HasColumnName("CPFCNPJParte")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired(false);

            builder
                .Property(o => o.NomeAdvogado)
                .HasColumnName("NomeAdvogado")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired(false);

            builder
                .Property(o => o.CPFAdvogado)
                .HasColumnName("CPFAdvogado")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired(false);


            builder
                .Property(o => o.OAB)
                .HasColumnName("OAB")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired(false);

            builder
                .Property(o => o.ProcessoId)
                .HasColumnName("ProcessoId")
                .HasColumnType("int");


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
