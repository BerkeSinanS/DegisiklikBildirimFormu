using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DegisiklikBildirimFormu.Migrations
{
    /// <inheritdoc />
    public partial class AddDurumColumnToFormlar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
              name: "Durum",
              table: "Formlar",
              type: "text",
              nullable: true,
              defaultValue: "Bekliyor");
            migrationBuilder.Sql("UPDATE Formlar SET Durum = 'Bekliyor' WHERE Durum IS NULL;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
          
        }
    }
}
