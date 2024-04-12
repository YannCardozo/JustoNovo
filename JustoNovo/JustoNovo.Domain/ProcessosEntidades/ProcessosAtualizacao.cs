using JustoNovo.Domain.Base;

namespace JustoNovo.Domain.ProcessosEntidades
{
    public class ProcessosAtualizacao : Entity<int>
    {
        public string CodPJEC { get; set; }
        public string? ConteudoAtualizacao { get; set; }
        public string? TituloMovimento { get; set; }
        public DateOnly DataMovimentacao { get; set; }
        public int ProcessoId {get;set;}
        public Processo Processo { get; set;}
    }
}
