using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Patients.Api.Utilities;

#nullable disable

namespace Patients.Api.Migrations
{
    public partial class Initial : Migration
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
                    feactulizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    febaja = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maestras", x => x.nmmaestro);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    nmid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cddocument = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    dsnombres = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    dsapellidos = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    fenacimiento = table.Column<DateTime>(type: "date", nullable: false),
                    cdtipo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    cdgenero = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    cdusuario = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    dsdireccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    dsphoto = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    cdtelefono_fijo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    cdtelefono_movil = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    dsemail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    feregistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    feactulizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    febaja = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.nmid);
                });

            migrationBuilder.CreateTable(
                name: "DataMaestra",
                columns: table => new
                {
                    nmdato = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    nmmaestro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    dsdato = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    feregistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    feactulizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    nmid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nmid_persona = table.Column<int>(type: "int", nullable: false),
                    nmid_medicotra = table.Column<int>(type: "int", nullable: false),
                    cdusuario = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    condicion = table.Column<string>(type: "text", maxLength: 20, nullable: true),
                    feregistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    feactulizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    febaja = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataMaestra_nmmaestro",
                table: "DataMaestra",
                column: "nmmaestro");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_nmid_medicotra",
                table: "Pacientes",
                column: "nmid_medicotra");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_nmid_persona",
                table: "Pacientes",
                column: "nmid_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_cddocument",
                table: "Personas",
                column: "cddocument");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_cdtipo",
                table: "Personas",
                column: "cdtipo");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_dsnombres",
                table: "Personas",
                column: "dsnombres");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_fenacimiento",
                table: "Personas",
                column: "fenacimiento");

            migrationBuilder.InsertData(
          table: "Maestras",
          columns: new[] { "nmmaestro", "dsmaestro", "feregistro", "feactulizacion" },
          values: new object[]
          {
                Consts.MASTER_GENDER_ID,
                Consts.GENDER,
                DateTime.UtcNow,
                DateTime.UtcNow
          });

            migrationBuilder.InsertData(
            table: "Maestras",
            columns: new[] { "nmmaestro", "dsmaestro", "feregistro", "feactulizacion" },
            values: new object[]
            {
                Consts.MASTER_USER_TYPES_ID,
                Consts.USER_TYPE,
                DateTime.UtcNow,
                DateTime.UtcNow
            });

            //Insert data masters 

            migrationBuilder.InsertData(
            table: "DataMaestra",
            columns: new[] { "nmdato", "nmmaestro", "dsdato", "feregistro", "feactulizacion" },
            values: new object[]
            {
                Consts.DATA_FAMELE_ID,
                Consts.MASTER_GENDER_ID,
                Consts.FAMELE,
                DateTime.UtcNow,
                DateTime.UtcNow
            });

            migrationBuilder.InsertData(
            table: "DataMaestra",
            columns: new[] { "nmdato", "nmmaestro", "dsdato", "feregistro", "feactulizacion" },
            values: new object[]
            {
                Consts.DATA_MALE_ID,
                Consts.MASTER_GENDER_ID,
                Consts.MALE,
                DateTime.UtcNow,
                DateTime.UtcNow
            });

            migrationBuilder.InsertData(
            table: "DataMaestra",
            columns: new[] { "nmdato", "nmmaestro", "dsdato", "feregistro", "feactulizacion" },
            values: new object[]
            {
                Consts.DATA_ANOTHER_ID,
                Consts.MASTER_GENDER_ID,
                Consts.ANOTHER,
                DateTime.UtcNow,
                DateTime.UtcNow
            });

            migrationBuilder.InsertData(
            table: "DataMaestra",
            columns: new[] { "nmdato", "nmmaestro", "dsdato", "feregistro", "feactulizacion" },
            values: new object[]
            {
                Consts.DATA_PATIENT_ID,
                Consts.MASTER_USER_TYPES_ID,
                Consts.PATIENT,
                DateTime.UtcNow,
                DateTime.UtcNow
            });

            migrationBuilder.InsertData(
            table: "DataMaestra",
            columns: new[] { "nmdato", "nmmaestro", "dsdato", "feregistro", "feactulizacion" },
            values: new object[]
            {
                Consts.DATA_DOCTOR_ID,
                Consts.MASTER_USER_TYPES_ID,
                Consts.DOCTOR,
                DateTime.UtcNow,
                DateTime.UtcNow
            });

            migrationBuilder.InsertData(
            table: "DataMaestra",
            columns: new[] { "nmdato", "nmmaestro", "dsdato", "feregistro", "feactulizacion" },
            values: new object[]
            {
                Consts.DATA_EMPLOYEE_ID,
                Consts.MASTER_USER_TYPES_ID,
                Consts.EMPLOYEE,
                DateTime.UtcNow,
                DateTime.UtcNow
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataMaestra");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Maestras");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
