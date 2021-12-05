using Microsoft.EntityFrameworkCore.Migrations;

namespace InfrastructureRepository.Migrations
{
    public partial class token2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tokens",
                schema: "Admin",
                table: "Tokens");

            migrationBuilder.RenameTable(
                name: "Tokens",
                schema: "Admin",
                newName: "TokenInfo",
                newSchema: "Admin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TokenInfo",
                schema: "Admin",
                table: "TokenInfo",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TokenInfo",
                schema: "Admin",
                table: "TokenInfo");

            migrationBuilder.RenameTable(
                name: "TokenInfo",
                schema: "Admin",
                newName: "Tokens",
                newSchema: "Admin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tokens",
                schema: "Admin",
                table: "Tokens",
                column: "Id");
        }
    }
}
