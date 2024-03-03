using Justo.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using JustoNovo.Domain.ProcessosEntidades;

namespace Justo.Data.Mapping
{
    public class Advogado_especialidadeMap : IEntityTypeConfiguration<AdvogadoEspecialidade>
    {

        public void Configure(EntityTypeBuilder<AdvogadoEspecialidade> builder)
        {
            // Tabela
            builder.ToTable("Advogados_Especialidades");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_Advogados_Especialidades");

            builder
                //precisa do identity? para associar o cliente a  
                .Property(o => o.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                //.UseIdentityColumn()
                .HasColumnType("int");


            builder
                .Property(o => o.Nome_area_direito)
                .HasColumnName("Nome_area_direito")
                .HasColumnType("varchar")
                .HasMaxLength(35);

            ////chave estrangeira
            builder
                .Property(o => o.AdvogadoId)
                .HasColumnName("AdvogadoId")
                .HasColumnType("int");

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
