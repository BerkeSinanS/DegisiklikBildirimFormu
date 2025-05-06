using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DegisiklikBildirimFormu.Migrations
{
    /// <inheritdoc />
    public partial class AddAdetColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Adet",
                table: "EskiYeniKodlar",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 1,
                column: "Adet",
                value: 0);

            migrationBuilder.UpdateData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 2,
                column: "Adet",
                value: 0);

            migrationBuilder.UpdateData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 3,
                column: "Adet",
                value: 0);

            migrationBuilder.UpdateData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 4,
                column: "Adet",
                value: 0);

            migrationBuilder.UpdateData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 5,
                column: "Adet",
                value: 0);

            migrationBuilder.UpdateData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 6,
                column: "Adet",
                value: 0);

            migrationBuilder.UpdateData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 7,
                column: "Adet",
                value: 0);

            migrationBuilder.UpdateData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 8,
                column: "Adet",
                value: 0);

            migrationBuilder.UpdateData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 9,
                column: "Adet",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adet",
                table: "EskiYeniKodlar");
        }
    }
}
