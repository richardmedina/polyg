using Microsoft.EntityFrameworkCore.Migrations;

namespace Polyg.Infrastructure.Domain.Migrations
{
    public partial class SeedingDataonLanguageEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Business",
                table: "Languages",
                columns: new[] { "Id", "CultureName", "Description", "IsActive", "Name" },
                values: new object[] { 1L, "en-US", "English (United States)", false, "English (US)" });

            migrationBuilder.InsertData(
                schema: "Business",
                table: "Languages",
                columns: new[] { "Id", "CultureName", "Description", "IsActive", "Name" },
                values: new object[] { 2L, "es-MX", "Spanish (Mexico)", false, "Spanish (MX)" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Business",
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Business",
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
