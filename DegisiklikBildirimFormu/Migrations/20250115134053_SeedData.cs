using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DegisiklikBildirimFormu.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Formlar",
                columns: new[] { "FormID", "Aciklama", "DegisiklikNumarasi", "KontrolEden", "Not", "Onaylayan", "Uygulama", "YayinTarihi" },
                values: new object[] { 1, "250 LT ÇABUK BOŞALTMADA YAY CE MİL KIRILMASININ ÖNÜNE GEÇİLEBİLMESİ İÇİN DEĞİŞİKLİK YAPILMIŞTIR. 250LT ve 400 LT boşaltmalarda artık 'KATRİÇ TİP 250 VE 400 LT BOŞALTMA' ya geçilecektir.", "2025_1", "", "Acil olarak geçilecektir.Stokta olanlar hurdyaa ayrılacaktır.", "", "Acil", new DateOnly(2025, 1, 7) });

            migrationBuilder.InsertData(
                table: "EskiYeniKodlar",
                columns: new[] { "KodID", "EskiKod", "FormID", "YeniKod" },
                values: new object[,]
                {
                    { 1, "90051866", 1, "90079123" },
                    { 2, "10012001-003", 1, "10012001-004" },
                    { 3, "12345678", 1, "12345678" },
                    { 4, "891011112", 1, "95460213" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EskiYeniKodlar",
                keyColumn: "KodID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Formlar",
                keyColumn: "FormID",
                keyValue: 1);
        }
    }
}
