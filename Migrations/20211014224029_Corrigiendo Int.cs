using Microsoft.EntityFrameworkCore.Migrations;

namespace Practica_2.Migrations
{
    public partial class CorrigiendoInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_userIdId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_userIdId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "userIdId",
                table: "Posts",
                newName: "userId");

            migrationBuilder.AddColumn<int>(
                name: "UserModelId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserModelId",
                table: "Posts",
                column: "UserModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserModelId",
                table: "Posts",
                column: "UserModelId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserModelId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserModelId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Posts",
                newName: "userIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_userIdId",
                table: "Posts",
                column: "userIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_userIdId",
                table: "Posts",
                column: "userIdId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
