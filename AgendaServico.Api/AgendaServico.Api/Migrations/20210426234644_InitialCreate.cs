using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaServico.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contato_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NumeroContato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdContato = table.Column<int>(type: "int", nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: false),
                    Ddd = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    TipoContato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumeroContato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NumeroContato_Categoria_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NumeroContato_Contato_IdContato",
                        column: x => x.IdContato,
                        principalTable: "Contato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contato_IdUsuario",
                table: "Contato",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_NumeroContato_IdCategoria",
                table: "NumeroContato",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_NumeroContato_IdContato",
                table: "NumeroContato",
                column: "IdContato");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NumeroContato");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
