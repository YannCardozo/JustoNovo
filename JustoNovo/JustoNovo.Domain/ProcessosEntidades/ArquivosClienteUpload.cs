using JustoNovo.Domain.Base;
using JustoNovo.Domain.ProcessosEntidades.Enums;

namespace JustoNovo.Domain.ProcessosEntidades
{
    public class ArquivosClienteUpload : Entity<int>
    {       
        public TipoArquivo TipoArquivo { get; set; }
        public string NomeArquivo { get; set; }


        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }


        public int ProcessoId { get; set; }
        public Processo Processo { get; set; }


    }
}
