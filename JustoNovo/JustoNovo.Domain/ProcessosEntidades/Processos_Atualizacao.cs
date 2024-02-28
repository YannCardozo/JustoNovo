using JustoNovo.Domain.Base;

namespace JustoNovo.Domain.ProcessosEntidades

{


    //entidade destinada a movimentação processual, inserida no banco após novas atualizações.
    public class Processos_Atualizacao : Entity<int>
    {   
        public string Movimentacao_processual_atualizacao { get; set; }
        public string Julgamento_status_atualizacao { get; set; }
        public DateTime Data_vencimento_processual_atualizacao { get; set; }
        public string Conteudo_atualizacao { get; set; }

        //verificar no webscrapping como que será feita o armazenamento do link dos arquivos e se é possível pegar apenas o link
        //se é possível fazer isso sem se autenticar previamente
        public string? Link_arquivos_atualizacao { get; set; }
        public string? Tipo_De_Acao_atualizacao { get; set; }
        public string? Orgao_Julgador_atualizacao { get; set; }
        //o que é marcação de data?
        public DateTime Marcação_de_data_atualizacao { get; set; }

        //campo para editar em crud obs referente ao processo
        public string? Descrição_da_Movimentação { get; set; }
        //Andamento, julgamento, marcação de data, data de vencimento protestual
        public string Comarca_atual_atualizacao { get; set; }

        public bool Status_Processo_atualizacao { get; set; }



        //chave estrangeira

        public int ProcessoId {get;set;}
        public Processos Processos { get; set;}
    }
}
