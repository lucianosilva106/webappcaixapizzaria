using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webappcaixapizzaria.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caixacontrole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datahoraabertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Idfuncionario = table.Column<int>(type: "int", nullable: false),
                    Valorfundocaixa = table.Column<double>(type: "float", nullable: false),
                    Datahorafechamento = table.Column<int>(type: "int", nullable: false),
                    Valorfinalcaixa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caixacontrole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Caixalancamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idcaixacontrole = table.Column<int>(type: "int", nullable: false),
                    Datahora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipolancamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Idformapagamento = table.Column<int>(type: "int", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caixalancamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Formapagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formapagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fun_nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fun_chapeira = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fun_login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fun_senha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caixacontrole");

            migrationBuilder.DropTable(
                name: "Caixalancamento");

            migrationBuilder.DropTable(
                name: "Formapagamento");

            migrationBuilder.DropTable(
                name: "Funcionario");
        }
    }
}
