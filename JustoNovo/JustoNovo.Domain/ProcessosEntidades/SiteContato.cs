using JustoNovo.Domain.Base;
using JustoNovo.Domain.ProcessosEntidades.ValueObjects;
using System.Globalization;

namespace JustoNovo.Domain.ProcessosEntidades
{
    public class SiteContato : Entity<int>
    {      
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Assunto { get; set; }
        public string Arquivos { get; set; }
        public string Conteudo { get; set; }
        public string TipoCausaContato { get; set; }        
        public bool AnalisadoContato { get; set; }
       
    }              

}
