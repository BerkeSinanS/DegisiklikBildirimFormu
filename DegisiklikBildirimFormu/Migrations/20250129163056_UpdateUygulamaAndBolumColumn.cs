using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DegisiklikBildirimFormu.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUygulamaAndBolumColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bolum",
                table: "Formlar",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Formlar",
                keyColumn: "FormID",
                keyValue: 1,
                columns: new[] { "Bolum"},
                values: new object[] { "Tasarım Bölümü"});

            migrationBuilder.UpdateData(
                table: "Formlar",
                keyColumn: "FormID",
                keyValue: 2,
                columns: new[] { "Bolum", "Uygulama" },
                values: new object[] { "Arge Bölümü", "Normal öncelikli" });

            migrationBuilder.UpdateData(
                table: "Formlar",
                keyColumn: "FormID",
                keyValue: 3,
                columns: new[] { "Bolum", "Uygulama" },
                values: new object[] { "Arge Bölümü", "Düşük öncelikli" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bolum",
                table: "Formlar");

            migrationBuilder.UpdateData(
                table: "Formlar",
                keyColumn: "FormID",
                keyValue: 2,
                column: "Uygulama",
                value: "Bakım");

            migrationBuilder.UpdateData(
                table: "Formlar",
                keyColumn: "FormID",
                keyValue: 3,
                column: "Uygulama",
                value: "Yeni Ürün");
        }
    }
}
