using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DegisiklikBildirimFormu.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formlar",
                columns: table => new
                {
                    FormID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uygulama = table.Column<string>(type: "text", nullable: false),
                    Aciklama = table.Column<string>(type: "text", nullable: false),
                    Not = table.Column<string>(type: "text", nullable: false),
                    YayinTarihi = table.Column<DateOnly>(type: "date", nullable: false),
                    Onaylayan = table.Column<string>(type: "text", nullable: false),
                    KontrolEden = table.Column<string>(type: "text", nullable: false),
                    DegisiklikNumarasi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formlar", x => x.FormID);
                });

            migrationBuilder.CreateTable(
                name: "EskiYeniKodlar",
                columns: table => new
                {
                    KodID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FormID = table.Column<int>(type: "integer", nullable: false),
                    EskiKod = table.Column<string>(type: "text", nullable: false),
                    YeniKod = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EskiYeniKodlar", x => x.KodID);
                    table.ForeignKey(
                        name: "FK_EskiYeniKodlar_Formlar_FormID",
                        column: x => x.FormID,
                        principalTable: "Formlar",
                        principalColumn: "FormID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EskiYeniKodlar_FormID",
                table: "EskiYeniKodlar",
                column: "FormID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EskiYeniKodlar");

            migrationBuilder.DropTable(
                name: "Formlar");
        }
    }
}
