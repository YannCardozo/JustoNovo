using JustoNovo.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustoNovo.Domain.ProcessosEntidades
{
    public class Processos : Entity<int>  
    {
        //destinado a codigo do processo de acordo com a numeração do TJ
        //possivelmente pelo cod_processo faremos a distinção se em cada processo ( numeração dele ) , ele não muda.
        public string CodProcessoTJ { get; set; }
        public string NomeCliente { get; set; }
        public string? NomeAutor { get; set; }
        public string? NomeReu { get; set; }
        //areas de direito do processo
        public string TipoProcesso { get; set; }
        public string Situacao { get; set; }
        public string ComarcaInicial { get; set; }
        public string ConteudoInicial { get; set; }
        //destinado a observações para incluir no processo
        public string? ObsProcesso { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFim { get; set; }

        //cliente é ativo ou passivo
        public string PoloCliente { get; set; }


        //Lisconsorcio nao clientes serão a parte oposta aos clientes do advogado
        public ICollection<ProcessosClientesReu>? ProcessosClientesReu { get; set; } 

        //Lisconsorcio clientes será a parte interessada do advogado
        public ICollection<Clientes>? LisconsorcioAutor { get; set; }

        public ICollection<Advogado>? Advogados { get; set; } = new List<Advogado>();


        //chaves estrangeiras

        //public int ClienteId { get; set; }
        //public int AdvogadoId { get; set; }


        public int ProcessosDetalhesId { get; set; }
        public ProcessosDetalhes ProcessosDetalhes { get; set; }


        //metodos de negocio

    }
}
