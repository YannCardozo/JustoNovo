using JustoNovo.Domain.Base;
using JustoNovo.Domain.ProcessosEntidades.ValueObjects;

namespace JustoNovo.Domain.ProcessosEntidades
{
    public class Procurador : Entity<int>
    {


        public string Nome { get; set; }
        public string NomeMae { get; set; }  
        public Cpf Cpf { get; set; }
        public string Rg { get; set; }
      
        public string ComprovanteDeResidencia { get; set; }
        public string? Cnh { get; set; }
        public string? ContratoSocial { get; set; }
        public string? Cnpj { get; set; }
        public string? CertificadoReservista{ get; set; }
        public string ProcuracaoRepresentacaoLegal { get; set; }
        public string? PisPasep { get; set; }
        public string? CLT { get; set; }
        public string? NIS { get; set; }


        //pessoais
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Ocupacao { get; set; }
        public string? Renda { get; set; }
        public string? Escolaridade{ get; set; }
        public string Nacionalidade { get; set; }
        public string EstadoCivil { get; set; }
        public string? Banco { get; set; }
        public string? AgenciaBancaria { get; set; }
        public string? ContaCorrente { get; set; }
        public string Telefone { get; set; }
        public string? ContatoDeConfianca { get; set; }
        public string Email { get; set; }

        //PF ou PJ
        public string TipoPessoa { get; set; }

        public Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }


        public List<ArquivosClienteUpload> ArquivosClientes { get; set; }




        public int ProcessoId { get; set; }


        public ICollection<Cliente> Clientes = new List<Cliente>();




    }
}
