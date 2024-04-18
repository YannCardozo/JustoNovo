using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using JustoNovo.Domain.ProcessosEntidades;

namespace Justo.Data.Mapping
{
    public class AdvogadoMap : IEntityTypeConfiguration<Advogado>
    {

        public void Configure(EntityTypeBuilder<Advogado> builder)
        {

            builder.ToTable("Advogado");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_Advogado");

            builder
                .Property(o => o.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                .HasColumnType("int");

            builder
                .Property(o => o.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired(false);

            builder
                .Property(o => o.Oab)
                .HasColumnName("Oab")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired(false);

            builder
                .Property(o => o.Cpf)
                .HasColumnName("Cpf")
                .HasColumnType("varchar")
                .HasMaxLength(11)
                .IsRequired(false);


            // Mapeamento da coleção Processos
            // Mapeamento da coleção Processos
            builder.HasMany(a => a.Processos)
                   .WithMany(p => p.Advogados)
                   .UsingEntity(j =>
                   {
                       j.ToTable("ProcessoAdvogados"); // Nome da tabela de junção
                       j.Property(pa => pa.Id).HasColumnName("ProcessoAdvogadoId"); // Renomeia a coluna de chave primária na tabela de junção
                   },
                   j => j.HasOne(pa => pa.Processo)
                         .WithMany()
                         .HasForeignKey(pa => pa.ProcessoId),
                   j => j.HasOne(pa => pa.Advogado)
                         .WithMany()
                         .HasForeignKey(pa => pa.AdvogadoId),
                   j =>
                   {
                       j.HasKey(pa => new { pa.ProcessoId, pa.AdvogadoId }); // Chaves primárias compostas
                   });


            // Mapeamento da coleção AdvogadosEspecialidades
            builder.HasMany(a => a.AdvogadosEspecialidades)
                   .WithOne()
                   .HasForeignKey(ae => ae.AdvogadoId)
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

            //public ICollection<AdvogadoEspecialidade> AdvogadosEspecialidades { get; set; } = new List<AdvogadoEspecialidade>();

            //public ICollection<Processo> Processos = new List<Processo>();
        }
    }
}
