using Microsoft.EntityFrameworkCore.Migrations;

namespace Polyg.Infrastructure.Domain.Migrations
{
    public partial class AddedPhrases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phrases",
                schema: "Business",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(nullable: true),
                    LanguageFromId = table.Column<long>(nullable: true),
                    LanguageToId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phrases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phrases_Languages_LanguageFromId",
                        column: x => x.LanguageFromId,
                        principalSchema: "Business",
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phrases_Languages_LanguageToId",
                        column: x => x.LanguageToId,
                        principalSchema: "Business",
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phrases_AuthUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "Security",
                        principalTable: "AuthUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phrases_LanguageFromId",
                schema: "Business",
                table: "Phrases",
                column: "LanguageFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Phrases_LanguageToId",
                schema: "Business",
                table: "Phrases",
                column: "LanguageToId");

            migrationBuilder.CreateIndex(
                name: "IX_Phrases_UserId",
                schema: "Business",
                table: "Phrases",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phrases",
                schema: "Business");
        }
    }
}
