using JustoNovo.Domain.Base;

namespace JustoNovo.Domain.ProcessosEntidades
{
    public class ProcessosCompromissos : Entity<int>
    {        
        public string Nome { get; set; }
        public string NomeAdvogado { get; set; }
        public string NomeCliente { get; set; }
        public DateTime Data { get; set; }
        public string Obs { get; set; }
        public string Local { get; set; }
        public string Prioridade { get; set; }
        public string Status { get; set; }
        public DateTime DataProximoEvento { get; set; }
        public int ProcessoId { get; set; }
        public Processo Processo { get; set; }
    }
}
