using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace WebService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estacionamento",
                columns: table => new
                {
                    EstacionamentoID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomeFantasia = table.Column<string>(nullable: true),
                    RazaoSocial = table.Column<string>(nullable: true),
                    CNPJ = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estacionamento", x => x.EstacionamentoID);
                });

            migrationBuilder.CreateTable(
                name: "Motorista",
                columns: table => new
                {
                    MotoristaID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomeCompleto = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: true),
                    Nascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorista", x => x.MotoristaID);
                });

            migrationBuilder.CreateTable(
                name: "EstacionamentoFluxo",
                columns: table => new
                {
                    EstacionamentoFluxoID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EstacionamentoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstacionamentoFluxo", x => x.EstacionamentoFluxoID);
                    table.ForeignKey(
                        name: "FK_EstacionamentoFluxo_Estacionamento_EstacionamentoID",
                        column: x => x.EstacionamentoID,
                        principalTable: "Estacionamento",
                        principalColumn: "EstacionamentoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EstacionamentoValores",
                columns: table => new
                {
                    EstacionamentoValoresID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EstacionamentoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstacionamentoValores", x => x.EstacionamentoValoresID);
                    table.ForeignKey(
                        name: "FK_EstacionamentoValores_Estacionamento_EstacionamentoID",
                        column: x => x.EstacionamentoID,
                        principalTable: "Estacionamento",
                        principalColumn: "EstacionamentoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    ContatosID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MotoristaID = table.Column<int>(nullable: true),
                    EstacionamentoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.ContatosID);
                    table.ForeignKey(
                        name: "FK_Contatos_Estacionamento_EstacionamentoID",
                        column: x => x.EstacionamentoID,
                        principalTable: "Estacionamento",
                        principalColumn: "EstacionamentoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contatos_Motorista_MotoristaID",
                        column: x => x.MotoristaID,
                        principalTable: "Motorista",
                        principalColumn: "MotoristaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    EnderecosID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Rua = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    CEP = table.Column<string>(nullable: true),
                    MotoristaID = table.Column<int>(nullable: true),
                    EstacionamentoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.EnderecosID);
                    table.ForeignKey(
                        name: "FK_Enderecos_Estacionamento_EstacionamentoID",
                        column: x => x.EstacionamentoID,
                        principalTable: "Estacionamento",
                        principalColumn: "EstacionamentoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enderecos_Motorista_MotoristaID",
                        column: x => x.MotoristaID,
                        principalTable: "Motorista",
                        principalColumn: "MotoristaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locacao",
                columns: table => new
                {
                    LocacaoID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    EstacionamentoID = table.Column<int>(nullable: true),
                    MotoristaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacao", x => x.LocacaoID);
                    table.ForeignKey(
                        name: "FK_Locacao_Estacionamento_EstacionamentoID",
                        column: x => x.EstacionamentoID,
                        principalTable: "Estacionamento",
                        principalColumn: "EstacionamentoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Locacao_Motorista_MotoristaID",
                        column: x => x.MotoristaID,
                        principalTable: "Motorista",
                        principalColumn: "MotoristaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_EstacionamentoID",
                table: "Contatos",
                column: "EstacionamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_MotoristaID",
                table: "Contatos",
                column: "MotoristaID");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_EstacionamentoID",
                table: "Enderecos",
                column: "EstacionamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_MotoristaID",
                table: "Enderecos",
                column: "MotoristaID");

            migrationBuilder.CreateIndex(
                name: "IX_EstacionamentoFluxo_EstacionamentoID",
                table: "EstacionamentoFluxo",
                column: "EstacionamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_EstacionamentoValores_EstacionamentoID",
                table: "EstacionamentoValores",
                column: "EstacionamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_EstacionamentoID",
                table: "Locacao",
                column: "EstacionamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_MotoristaID",
                table: "Locacao",
                column: "MotoristaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "EstacionamentoFluxo");

            migrationBuilder.DropTable(
                name: "EstacionamentoValores");

            migrationBuilder.DropTable(
                name: "Locacao");

            migrationBuilder.DropTable(
                name: "Estacionamento");

            migrationBuilder.DropTable(
                name: "Motorista");
        }
    }
}
