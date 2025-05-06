using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DegisiklikBildirimFormu.Migrations
{
    /// <inheritdoc />
    public partial class DataSample : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Formlar",
                columns: new[] { "FormID", "Aciklama", "DegisiklikNumarasi", "KontrolEden", "Not", "Onaylayan", "Uygulama", "YayinTarihi", "Yayınlayan" },
                values: new object[,]
                {
                    { 2, "Makine bakım prosedürü güncellenmiştir. Bakımda kullanılan malzemeler değişmiştir.", "2025_2", "", "Bakım sırasında makine duruşları olacaktır.", "", "Bakım", new DateOnly(2025, 2, 1), "" },
                    { 3, "Yeni üretim hattı devreye alınmıştır. Üretim kapasitesi artırılmıştır.", "2025_3", "", "Yeni üretim hattı kullanılmaya başlanacaktır.", "", "Yeni Ürün", new DateOnly(2025, 3, 10), "" }
                });

            migrationBuilder.InsertData(
                table: "EskiYeniKodlar",
                columns: new[] { "KodID", "EskiKod", "FormID", "YeniKod" },
                values: new object[,]
                {
                    { 5, "20011001-001", 2, "20011001-002" },
                    { 6, "30012003-005", 2, "30012003-006" },
                    { 7, "40011100-003", 3, "40011100-004" },
                    { 8, "50022001-007", 3, "50022001-008" },
                    { 9, "60033004-009", 3, "60033004-010" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Formlar",
                keyColumn: "FormID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Formlar",
                keyColumn: "FormID",
                keyValue: 3);
        }
    }
}
