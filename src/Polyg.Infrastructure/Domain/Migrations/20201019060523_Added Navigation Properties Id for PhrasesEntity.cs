using Microsoft.EntityFrameworkCore.Migrations;

namespace Polyg.Infrastructure.Domain.Migrations
{
    public partial class AddedNavigationPropertiesIdforPhrasesEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FromText",
                schema: "Business",
                table: "Phrases",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToText",
                schema: "Business",
                table: "Phrases",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromText",
                schema: "Business",
                table: "Phrases");

            migrationBuilder.DropColumn(
                name: "ToText",
                schema: "Business",
                table: "Phrases");
        }
    }
}
