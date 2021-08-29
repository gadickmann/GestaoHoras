using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoHoras3.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Equipe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEquipePessoa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipe", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EquipePessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEquipe = table.Column<int>(type: "int", nullable: false),
                    IdPessoa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipePessoa", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Lancamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPessoa = table.Column<int>(type: "int", nullable: false),
                    idProjeto = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HoraInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HoraFim = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lancamento", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Projetos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Equipe",
                columns: new[] { "Id", "IdEquipePessoa", "Titulo" },
                values: new object[,]
                {
                    { 1, 1, "Equipe Guerreiros" },
                    { 2, 1, "Equipe Masters" },
                    { 3, 2, "Equipe Reserva" }
                });

            migrationBuilder.InsertData(
                table: "EquipePessoa",
                columns: new[] { "Id", "IdEquipe", "IdPessoa" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Lancamento",
                columns: new[] { "Id", "Data", "HoraFim", "HoraInicio", "IdPessoa", "idProjeto" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 15, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 3, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 13, 30, 0, 0, DateTimeKind.Unspecified), 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 11, "Amadeu" },
                    { 10, "Carla" },
                    { 9, "Julia" },
                    { 8, "Roberto" },
                    { 7, "Ana Paula" },
                    { 2, "Carlos" },
                    { 5, "Edson" },
                    { 4, "Manoel" },
                    { 3, "Maria" },
                    { 1, "Jorge" },
                    { 6, "Joaquim" }
                });

            migrationBuilder.InsertData(
                table: "Projetos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Pequenas manutenções" },
                    { 2, "Refatoração da rotina XPTO" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipe");

            migrationBuilder.DropTable(
                name: "EquipePessoa");

            migrationBuilder.DropTable(
                name: "Lancamento");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Projetos");
        }
    }
}
