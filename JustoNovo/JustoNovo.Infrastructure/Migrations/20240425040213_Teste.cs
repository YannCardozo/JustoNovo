using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JustoNovo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advogado",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Oab = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Cpf = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: true),
                    ProcessoId = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CadastradoPor = table.Column<int>(type: "int", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoPor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advogado", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rua = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Numero = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Municipio = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    UF = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    Cep = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Referencia = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CadastradoPor = table.Column<int>(type: "int", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoPor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SiteContato",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Assunto = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Conteudo = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: false),
                    TipoCausaContato = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false),
                    AnalisadoContato = table.Column<bool>(type: "bit", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CadastradoPor = table.Column<int>(type: "int", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoPor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteContato", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AdvogadosEspecialidades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAreaDireito = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: true),
                    AdvogadoId = table.Column<int>(type: "int", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cadastradopor = table.Column<int>(type: "int", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizadopor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvogadosEspecialidades", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AdvogadosEspecialidades_Advogado_AdvogadoId",
                        column: x => x.AdvogadoId,
                        principalTable: "Advogado",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Processos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodPJEC = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    ObsProcesso = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: true),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MeioDeComunicacao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    MeioDeComunicacaoData = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prazo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    ProximoPrazo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    ProximoPrazoData = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    PJECAcao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    UltimaMovimentacaoProcessual = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    UltimaMovimentacaoProcessualData = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdvogadaCiente = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Comarca = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    OrgaoJulgador = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Competencia = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    MotivosProcesso = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    SegredoJustica = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    JusGratis = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    TutelaLiminar = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    Prioridade = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    Autuacao = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    TituloProcesso = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    PartesProcesso = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    DataAbertura = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValorDaCausa = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    AdvogadoId = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CadastradoPor = table.Column<int>(type: "int", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoPor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Processos_Advogado_AdvogadoId",
                        column: x => x.AdvogadoId,
                        principalTable: "Advogado",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    NomeMae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf_Valor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rg = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: true),
                    ComprovanteDeResidencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnh = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    ContratoSocialCliente = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Cnpj = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    CertificadoReservista = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    ProcuracaoRepresentacaoLegal = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    PisPasep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodClt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ocupacao = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: true),
                    Renda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Escolaridade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nacionalidade = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: true),
                    EstadoCivil = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: true),
                    Banco = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: true),
                    AgenciaBancaria = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: true),
                    ContaCorrente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: true),
                    Contato = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: true),
                    Email = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: true),
                    Tipo = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true),
                    ReuAutor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoId = table.Column<int>(type: "int", nullable: true),
                    ProcessoId = table.Column<int>(type: "int", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CadastradoPor = table.Column<int>(type: "int", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoPor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Clientes_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Polo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeParte = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    TipoParte = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: true),
                    CPFCNPJParte = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NomeAdvogado = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    CPFAdvogado = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    OAB = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    ProcessoId = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CadastradoPor = table.Column<int>(type: "int", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoPor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Polo_Processos_ProcessoId",
                        column: x => x.ProcessoId,
                        principalTable: "Processos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcessosAtualizacao",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodPJEC = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    ConteudoAtualizacao = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: true),
                    TituloMovimento = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    DataMovimentacao = table.Column<DateOnly>(type: "date", nullable: true),
                    ProcessoId = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CadastradoPor = table.Column<int>(type: "int", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoPor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessosAtualizacao", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProcessosAtualizacao_Processos_ProcessoId",
                        column: x => x.ProcessoId,
                        principalTable: "Processos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcessosCompromissos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NomeAdvogado = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NomeCliente = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Obs = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: false),
                    Local = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Prioridade = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Status = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    DataProximoEvento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProcessoId = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CadastradoPor = table.Column<int>(type: "int", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoPor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessosCompromissos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProcessosCompromissos_Processos_ProcessoId",
                        column: x => x.ProcessoId,
                        principalTable: "Processos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvogadosEspecialidades_AdvogadoId",
                table: "AdvogadosEspecialidades",
                column: "AdvogadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EnderecoId",
                table: "Clientes",
                column: "EnderecoId",
                unique: true,
                filter: "[EnderecoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Polo_ProcessoId",
                table: "Polo",
                column: "ProcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_AdvogadoId",
                table: "Processos",
                column: "AdvogadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessosAtualizacao_ProcessoId",
                table: "ProcessosAtualizacao",
                column: "ProcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessosCompromissos_ProcessoId",
                table: "ProcessosCompromissos",
                column: "ProcessoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvogadosEspecialidades");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Polo");

            migrationBuilder.DropTable(
                name: "ProcessosAtualizacao");

            migrationBuilder.DropTable(
                name: "ProcessosCompromissos");

            migrationBuilder.DropTable(
                name: "SiteContato");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Processos");

            migrationBuilder.DropTable(
                name: "Advogado");
        }
    }
}
