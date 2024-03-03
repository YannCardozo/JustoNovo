using JustoNovo.Domain.Base;

namespace JustoNovo.Domain.ProcessosEntidades
{
    public class ProcessosDespesa : Entity<int>
    {
       
        public string CodProcessoTJDespesa { get; set; }
        public string NomeCliente { get; set; }
        public string NomeDespesa { get; set; }
        public string Valor { get; set; }
        public string NomeAdvogado { get; set; }
        public string Tipo { get; set; }
        public int ProcessoId { get; set; }
        public Processo Processo { get; set; }

    }
}
