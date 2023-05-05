using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Patients.Api.Migrations
{
    public partial class AddPersonasDataMaestras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cdgenero",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "cdtipo",
                table: "Personas");

            migrationBuilder.CreateTable(
                name: "PersonasDataMaestras",
                columns: table => new
                {
                    nmid_persona = table.Column<int>(type: "int", nullable: false),
                    nmdato = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonasDataMaestras", x => new { x.nmid_persona, x.nmdato });
                    table.ForeignKey(
                        name: "FK_PersonasDataMaestras_DataMaestra_nmdato",
                        column: x => x.nmdato,
                        principalTable: "DataMaestra",
                        principalColumn: "nmdato",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonasDataMaestras_Personas_nmid_persona",
                        column: x => x.nmid_persona,
                        principalTable: "Personas",
                        principalColumn: "nmid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonasDataMaestras_nmdato",
                table: "PersonasDataMaestras",
                column: "nmdato");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonasDataMaestras");

            migrationBuilder.AddColumn<string>(
                name: "cdgenero",
                table: "Personas",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cdtipo",
                table: "Personas",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);
        }
    }
}
