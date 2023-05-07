using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Patients.Api.Migrations
{
    public partial class AddSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pacientes_Personas_nmid_persona",
                        column: x => x.nmid_persona,
                        principalTable: "Personas",
                        principalColumn: "nmid",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "IX_Personas_dsnombres",
                table: "Personas",
                column: "dsnombres");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_fenacimiento",
                table: "Personas",
                column: "fenacimiento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DataMaestra");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Maestras");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
