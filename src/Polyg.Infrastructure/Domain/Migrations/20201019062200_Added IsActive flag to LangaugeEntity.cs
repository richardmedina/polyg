using Microsoft.EntityFrameworkCore.Migrations;

namespace Polyg.Infrastructure.Domain.Migrations
{
    public partial class AddedIsActiveflagtoLangaugeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "Business",
                table: "Languages",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "Business",
                table: "Languages");
        }
    }
}
