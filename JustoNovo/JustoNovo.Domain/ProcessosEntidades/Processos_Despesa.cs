using JustoNovo.Domain.Base;

namespace JustoNovo.Domain.ProcessosEntidades
{
    public class Processos_Despesa : Entity<int>
    {
        //processos, advogado e clientes
        public string Cod_processo_TJ_despesa { get; set; }
        public string Nome_despesa { get; set; }
        public string Valor_despesa { get; set; }
        public string Nome_advogado_despesa { get; set; }
        public string Nome_cliente_despesa { get; set; }
        public string Tipo_despesa { get; set; }




        //chave estrangeira
        public int ProcessoId { get; set; }
        public int ClienteId { get; set; }
        public int AdvogadoId { get; set; }
        //deveria ter chave estrangeira de ClientId?
    }
}
