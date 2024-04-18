using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using JustoNovo.Domain.ProcessosEntidades;

namespace Justo.Data.Mapping
{
    public class SiteContatoMap : IEntityTypeConfiguration<SiteContato>
    {

        public void Configure(EntityTypeBuilder<SiteContato> builder)
        {

            builder.ToTable("SiteContato");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_SiteContato");

            builder
                .Property(o => o.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                .HasColumnType("int");


            builder
                .Property(o => o.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(200);

            builder
                .Property(o => o.Telefone)
                .HasColumnName("Telefone")
                .HasColumnType("varchar")
                .HasMaxLength(20);

            builder
                .Property(o => o.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder
                .Property(o => o.Assunto)
                .HasColumnName("Assunto")
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder
                .Property(o => o.Conteudo)
                .HasColumnName("Conteudo")
                .HasColumnType("varchar")
                .HasMaxLength(400);

            builder
                .Property(o => o.TipoCausaContato)
                .HasColumnName("TipoCausaContato")
                .HasColumnType("varchar")
                .HasMaxLength(35);

            builder
                .Property(o => o.AnalisadoContato)
                .HasColumnName("AnalisadoContato")
                .HasColumnType("bit");

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
