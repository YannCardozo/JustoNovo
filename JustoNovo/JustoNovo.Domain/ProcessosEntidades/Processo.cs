using JustoNovo.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JustoNovo.Domain.ProcessosEntidades
{
    public class Processo : Entity<int>
    {
        public string CodPJEC { get; set; }
        public string? ObsProcesso { get; set; }
        public DateTime? DataFim { get; set; }



        public string? MeioDeComunicacao { get; set; }
        public DateTime? MeioDeComunicacaoData { get; set; }
        public string? Prazo { get; set; }
        public string? ProximoPrazo { get; set; }
        public string? ProximoPrazoData { get; set; }
        public string? PJECAcao { get; set; }
        public string? UltimaMovimentacaoProcessual { get; set; }
        public DateTime? UltimaMovimentacaoProcessualData { get; set; }
        public string? AdvogadaCiente { get; set; }
        public string? Comarca { get; set; }
        public string? OrgaoJulgador { get; set; }
        public string? Competencia { get; set; }
        public string? MotivosProcesso { get; set; }
        public string? SegredoJustica { get; set; }
        public string? JusGratis { get; set; }
        public string? TutelaLiminar { get; set; }
        public string? Prioridade { get; set; }
        public string? Autuacao { get; set; }
        public Polo? PoloAtivo { get; set; }
        public Polo? PoloPassivo { get; set; }
        public string? TituloProcesso { get; set; }
        public string? PartesProcesso { get; set; }
        public DateTime? DataAbertura { get; set; }
        public string? ValorDaCausa { get; set; }




        public int AdvogadoId { get; set; }



        public ICollection<ProcessosCompromissos> ProcessosCompromissos = new List<ProcessosCompromissos>();
        //remapeado para que um advogado esteja para um processo apenas, 1:1
        public Advogado Advogado { get; set; } = new();
        public ICollection<ProcessosAtualizacao> ProcessosAtualizacoes { get; set; } = new List<ProcessosAtualizacao>();







    }
}
