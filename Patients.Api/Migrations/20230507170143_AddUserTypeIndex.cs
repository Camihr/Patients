using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Patients.Api.Migrations
{
    public partial class AddUserTypeIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Personas_cdtipo",
                table: "Personas",
                column: "cdtipo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Personas_cdtipo",
                table: "Personas");
        }
    }
}
