using JustoNovo.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustoNovo.Domain.ProcessosEntidades
{
    public class Polo : Entity<int>
    {

        public string? NomeParte { get; set; }
        public string? TipoParte { get; set; } 
        public string? CPFCNPJParte { get; set; }
        public string? NomeAdvogado { get; set; }
        public string? CPFAdvogado { get; set; }
        public string? OAB { get; set; }  


        public int ProcessoId { get; set; }
        public Processo Processo { get; set; } = new();
    }
}
