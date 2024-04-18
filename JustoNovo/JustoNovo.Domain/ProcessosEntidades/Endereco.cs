using JustoNovo.Domain.Base;

namespace JustoNovo.Domain.ProcessosEntidades
{
    public class Endereco : Entity<int>
    {      

        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
        public string Cep { get; set; }
        public string Referencia { get; set; }

        public int? ClienteId { get; set; }

        public Cliente EnderecoCliente { get; set; }
    }
}
