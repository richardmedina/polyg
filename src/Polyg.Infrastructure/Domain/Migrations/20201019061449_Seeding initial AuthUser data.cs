using Microsoft.EntityFrameworkCore.Migrations;

namespace Polyg.Infrastructure.Domain.Migrations
{
    public partial class SeedinginitialAuthUserdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Security",
                table: "AuthUser",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[] { 1L, "medina", "richard" });

            migrationBuilder.InsertData(
                schema: "Security",
                table: "AuthUser",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[] { 2L, "anonymous", "anonymous" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Security",
                table: "AuthUser",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Security",
                table: "AuthUser",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
