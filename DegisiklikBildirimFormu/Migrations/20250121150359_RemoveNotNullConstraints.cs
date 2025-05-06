using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DegisiklikBildirimFormu.Migrations
{
    /// <inheritdoc />
    public partial class RemoveNotNullConstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
           name: "Onaylayan",
           table: "Formlar",
           type: "text",
           nullable: true, 
           oldClrType: typeof(string),
           oldType: "text");

            migrationBuilder.AlterColumn<string>(
           name: "Yayınlayan",
           table: "Formlar",
           type: "text", 
           nullable: true, 
           oldClrType: typeof(string),
           oldType: "text");

            migrationBuilder.AlterColumn<string>(
           name: "KontrolEden",
           table: "Formlar",
           type: "text", 
           nullable: true, 
           oldClrType: typeof(string),
           oldType: "text");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
           name: "Onaylayan",
           table: "Formlar",
           type: "text",
           nullable: false, 
           oldClrType: typeof(string),
           oldType: "text");

            migrationBuilder.AlterColumn<string>(
           name: "Yayınlayan",
           table: "Formlar",
           type: "text",
           nullable: false, 
           oldClrType: typeof(string),
           oldType: "text");

            migrationBuilder.AlterColumn<string>(
           name: "KontrolEden",
           table: "Formlar",
           type: "text",
           nullable: false, 
           oldClrType: typeof(string),
           oldType: "text");
        }
    }
}
