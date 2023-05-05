using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Patients.Api.Migrations
{
    public partial class AddMastros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Maestras",
                columns: table => new
                {
                    nmmaestro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    dsmaestro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    feregistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    febaja = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maestras", x => x.nmmaestro);
                });

            migrationBuilder.CreateTable(
                name: "DataMaestra",
                columns: table => new
                {
                    nmdato = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    nmmaestro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    dsdato = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    feregistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    febaja = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataMaestra", x => x.nmdato);
                    table.ForeignKey(
                        name: "FK_DataMaestra_Maestras_nmmaestro",
                        column: x => x.nmmaestro,
                        principalTable: "Maestras",
                        principalColumn: "nmmaestro");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataMaestra_nmmaestro",
                table: "DataMaestra",
                column: "nmmaestro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataMaestra");

            migrationBuilder.DropTable(
                name: "Maestras");
        }
    }
}
