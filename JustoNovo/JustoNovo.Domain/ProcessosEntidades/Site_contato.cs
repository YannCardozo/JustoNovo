using JustoNovo.Domain.Base;

namespace JustoNovo.Domain.ProcessosEntidades
{
    public class Site_contato : Entity<int>
    {

        //se relacionar com clientes, para que permita virar cliente após verificação de ambas as partes
        //verificar como será o serviço de envio de arquivos, possibilitando subida pelo FTP de imagens/arquivos

        public string Nome_contato { get; set; }
        public string Telefone_contato { get; set; }
        public string Email_contato { get; set; }
        public string Assunto_contato { get; set; }
        public string Arquivos_Contato { get; set; }
        public string Conteudo_contato { get; set; }
        public string Tipo_causa_contato { get; set; }
        //destinado a um flag para saber se foi analizado ou nao
        public bool Analisado_contato { get; set; }

        //flag para incluir cliente na base de clientes?
        public bool Virar_cliente_contato { get; set; }

        //se depois adicionar a tabela cliente em caso de cliente fechar ser representado pelo adv, como faria?
        //para poder incluir ele como cliente
    }
}
