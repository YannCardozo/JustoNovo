using JustoNovo.Domain.Base;

namespace JustoNovo.Domain.ProcessosEntidades
{

    
    public class ProcessosAtualizacao : Entity<int>
    {   
        public string MovimentacaoProcessual { get; set; }
        public string JulgamentoStatus { get; set; }
        public DateTime DataVencimentoProcessual { get; set; }
        public string Conteudo { get; set; }
        public string? LinkArquivos { get; set; }
        public string? TipoDeAcao{ get; set; }
        public string? OrgaoJulgador { get; set; }     
        public DateTime MarcacaoDeData { get; set; }   
        public string ComarcaAtual { get; set; }
        public bool StatusProcesso { get; set; }
        public int ProcessoId {get;set;}
        public Processo Processo { get; set;}
    }
}
