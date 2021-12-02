using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InfrastructureRepository.Migrations
{
    public partial class DeleteBaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_BaseEntity_BaseEntityId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_Users_BaseEntityId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BaseEntityId",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BaseEntityId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BaseEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntity", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_BaseEntityId",
                table: "Users",
                column: "BaseEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_BaseEntity_BaseEntityId",
                table: "Users",
                column: "BaseEntityId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
