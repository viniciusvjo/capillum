using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Capillum.Migrations
{
    public partial class TabelaCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoMedio",
                table: "Servico",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(maxLength: 60, nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    CPF = table.Column<string>(maxLength: 11, nullable: false),
                    Sexo = table.Column<char>(nullable: false),
                    Rua = table.Column<string>(maxLength: 40, nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Bairro = table.Column<string>(maxLength: 40, nullable: false),
                    Cidade = table.Column<string>(maxLength: 40, nullable: false),
                    Estado = table.Column<string>(maxLength: 40, nullable: false),
                    CEP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoMedio",
                table: "Servico",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");
        }
    }
}
