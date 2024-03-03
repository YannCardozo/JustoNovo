

namespace JustoNovo.Domain.ProcessosEntidades.ValueObjects
{
    public class Cpf
    {
        public Cpf()
        {
                
        }
        public Cpf(string cpf)
        {
                Valor = cpf ?? throw new ArgumentNullException(nameof(cpf));
        }
        public string Valor { get; set; }
    }
}
