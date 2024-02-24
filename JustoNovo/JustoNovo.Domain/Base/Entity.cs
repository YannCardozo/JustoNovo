namespace JustoNovo.Domain.Base
{
    public class Entity<T>
    {
        public virtual T Id { get; set; }     
               
        public DateTime DataCadastro { get; set; }
        public int CadastradoPor { get; set; }     
        public DateTime DataAtualizacao { get; set; }
        public int AtualizadoPor { get; set; }
    }
}
