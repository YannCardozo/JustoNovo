

using JustoNovo.Domain.Base;

namespace JustoNovo.Domain.ProcessosEntidades
{
    public class Advogado_especialidade : Entity<int>
    {
        public string Nome_area_direito { get; set; }

        //chave estrangeira
        public int AdvogadoId { get; set; }

        // Relacionamento com Advogado
        public Advogado Advogados_FK { get; set; }


    }
}
