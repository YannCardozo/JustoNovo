﻿using JustoNovo.Domain.Base;

namespace JustoNovo.Domain.ProcessosEntidades
{
    public class Advogado : Entity<int>
    {
        public string? Nome { get; set; }
        public string? Oab { get; set; }
        public string? Cpf { get; set; }
        public ICollection<AdvogadoEspecialidade> AdvogadosEspecialidades { get; set; } = new List<AdvogadoEspecialidade>();

        public ICollection<Processo> Processos = new List<Processo>();  

        public int ProcessoId { get; set; }
    }
}
