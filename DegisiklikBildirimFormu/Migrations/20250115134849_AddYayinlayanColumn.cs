using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DegisiklikBildirimFormu.Migrations
{
    /// <inheritdoc />
    public partial class AddYayinlayanColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Yayınlayan",
                table: "Formlar",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Formlar",
                keyColumn: "FormID",
                keyValue: 1,
                column: "Yayınlayan",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Yayınlayan",
                table: "Formlar");
        }
    }
}
