using Microsoft.EntityFrameworkCore.Migrations;

namespace InfrastructureRepository.Migrations
{
    public partial class map : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.EnsureSchema(
                name: "Admin");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "UserInfo",
                newSchema: "Admin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInfo",
                schema: "Admin",
                table: "UserInfo",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInfo",
                schema: "Admin",
                table: "UserInfo");

            migrationBuilder.RenameTable(
                name: "UserInfo",
                schema: "Admin",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
