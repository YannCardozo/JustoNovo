﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using JustoNovo.Domain.ProcessosEntidades;

namespace Justo.Data.Mapping
{
    public class AdvogadoEspecialidadeMap : IEntityTypeConfiguration<AdvogadoEspecialidade>
    {

        public void Configure(EntityTypeBuilder<AdvogadoEspecialidade> builder)
        {
            // Tabela
            builder.ToTable("AdvogadosEspecialidades");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_AdvogadosEspecialidades");

            builder
                //precisa do identity? para associar o cliente a  
                .Property(o => o.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                //.UseIdentityColumn()
                .HasColumnType("int");


            builder
                .Property(o => o.NomeAreaDireito)
                .HasColumnName("NomeAreaDireito")
                .HasColumnType("varchar")
                .HasMaxLength(35);

            builder
                .Property(o => o.AdvogadoId);

            builder
                .HasOne(p => p.Advogado)
                .WithMany(a => a.AdvogadosEspecialidades)
                .HasForeignKey(pa => pa.AdvogadoId) // Propriedade de navegação para o relacionamento
                .IsRequired(false);


            //entidadebase

            builder
                    .Property(o => o.DataCadastro)
                    .HasColumnName("data_cadastro")
                    .HasColumnType("datetime2");

            builder
                .Property(o => o.DataAtualizacao)
                    .HasColumnName("data_atualizacao")
                    .HasColumnType("datetime2");

            builder
                .Property(o => o.CadastradoPor)
                    .HasColumnName("cadastradopor")
                    .HasColumnType("int");

            builder
                .Property(o => o.AtualizadoPor)
                    .HasColumnName("atualizadopor")
                    .HasColumnType("int");

        }
    }
}
