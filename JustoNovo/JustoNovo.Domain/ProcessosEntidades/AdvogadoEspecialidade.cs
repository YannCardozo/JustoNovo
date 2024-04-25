

using JustoNovo.Domain.Base;

namespace JustoNovo.Domain.ProcessosEntidades
{
    public class AdvogadoEspecialidade : Entity<int>
    {
        public string? NomeAreaDireito { get; set; }
        public int? AdvogadoId { get; set; }     
        public virtual Advogado? Advogado { get; set; } = new Advogado();


    }
}
