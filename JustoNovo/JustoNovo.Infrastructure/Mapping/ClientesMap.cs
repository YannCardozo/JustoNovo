using JustoNovo.Domain.ProcessosEntidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Justo.Data.Mapping
{
    public class ClientesMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            // Tabela
            builder.ToTable("Clientes");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_Clientes");

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
                .Property(o => o.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(80);


            builder
                .Property(o => o.Cpf)
                .HasColumnName("Cpf")
                .HasColumnType("varchar")
                .HasMaxLength(11);

            builder
                .Property(o => o.Rg)
                .HasColumnName("Rg")
                .HasColumnType("varchar")
                .HasMaxLength(9)
                .IsRequired(false); ;

            builder
                .Property(o => o.Cnh)
                .HasColumnName("Cnh")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired(false);

            builder
                .Property(o => o.ContratoSocialCliente)
                .HasColumnName("ContratoSocialCliente")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(false);

            builder
                .Property(o => o.Cnpj)
                .HasColumnName("Cnpj")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired(false);


            builder
                .Property(o => o.CertificadoReservista)
                .HasColumnName("CertificadoReservista")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired(false);

            builder
                .Property(o => o.ProcuracaoRepresentacaoLegal)
                .HasColumnName("ProcuracaoRepresentacaoLegal")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired(false);

            builder
                .Property(o => o.Genero)
                .HasColumnName("Genero")
                .HasColumnType("varchar")
                .HasMaxLength(13);

            builder
                .Property(o => o.DataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("datetime2");

            builder
                .Property(o => o.Ocupacao)
                .HasColumnName("Ocupacao")
                .HasColumnType("varchar")
                .HasMaxLength(35)
                .IsRequired(false);

            builder
                .Property(o => o.Nacionalidade)
                .HasColumnName("Nacionalidade")
                .HasColumnType("varchar")
                .HasMaxLength(35);

            builder
                .Property(o => o.EstadoCivil)
                .HasColumnName("EstadoCivil")
                .HasColumnType("varchar")
                .HasMaxLength(35);

            builder
                .Property(o => o.Banco)
                .HasColumnName("Banco")
                .HasColumnType("varchar")
                .HasMaxLength(35)
                .IsRequired(false);

            builder
                .Property(o => o.AgenciaBancaria)
                .HasColumnName("AgenciaBancaria")
                .HasColumnType("varchar")
                .HasMaxLength(35)
                .IsRequired(false);

            builder
                .Property(o => o.Telefone)
                .HasColumnName("Telefone")
                .HasColumnType("varchar")
                .HasMaxLength(11);

            builder
                .Property(o => o.Contato)
                .HasColumnName("Contato")
                .HasColumnType("varchar")
                .HasMaxLength(35)
                .IsRequired(false);

            builder
                .Property(o => o.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar")
                .HasMaxLength(35)
                .IsRequired(false);

            builder
                .Property(o => o.Tipo)
                .HasColumnName("Tipo")
                .HasColumnType("varchar")
                .HasMaxLength(2)
                .IsRequired(false);

            //public Endereco Endereco_cliente { get; set; }

            builder
                .HasOne(o => o.Endereco)  // Define o relacionamento
                .WithOne()                        // O relacionamento é de um para um (um cliente tem um endereço)
                .HasForeignKey<Endereco>(e => e.ClienteId);  // Define a chave estrangeira na entidade Endereco




            //chaves estrangeiras
            //public int EnderecoId { get; set; }
            //public int ProcessoId { get; set; }


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
