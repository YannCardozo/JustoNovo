using JustoNovo.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustoNovo.Domain.ProcessosEntidades
{
    public class Processo : Entity<int>  
    {
        public string CodProcessoTJ { get; set; }                
        public string TipoProcesso { get; set; }
        public string Situacao { get; set; }
        public string ValorDaCausa { get; set; }        
        public string? LinkArquivos{ get; set; }
        public string ComarcaInicial { get; set; }
        public string ConteudoInicial { get; set; }
       
        public string? ObsProcesso { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFim { get; set; }

        public ICollection<ProcessosCompromissos> ProcessosCompromissos = new List<ProcessosCompromissos>();
        public ICollection<Advogado> Advogados { get; set; } = new List<Advogado>();
        public ICollection<ProcessosAtualizacao> ProcessosAtualizacoes { get; set; } = new List<ProcessosAtualizacao>();        


    }
}
