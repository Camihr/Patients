using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Patients.Api.Migrations
{
    public partial class AddPacientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    nmid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nmid_persona = table.Column<int>(type: "int", nullable: false),
                    nmid_medicotra = table.Column<int>(type: "int", nullable: false),
                    feregistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    febaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    cdusuario = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    condicion = table.Column<string>(type: "text", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.nmid);
                    table.ForeignKey(
                        name: "FK_Pacientes_Personas_nmid_medicotra",
                        column: x => x.nmid_medicotra,
                        principalTable: "Personas",
                        principalColumn: "nmid",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pacientes_Personas_nmid_persona",
                        column: x => x.nmid_persona,
                        principalTable: "Personas",
                        principalColumn: "nmid",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_nmid_medicotra",
                table: "Pacientes",
                column: "nmid_medicotra");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_nmid_persona",
                table: "Pacientes",
                column: "nmid_persona");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
