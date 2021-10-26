using Microsoft.EntityFrameworkCore.Migrations;

namespace Practica_2.Migrations
{
    public partial class ReparandolaclaseUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Users_UserModelId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserModelId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_Users_UserModelId",
                table: "ToDos");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Address_addressId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "UsersApp");

            migrationBuilder.RenameIndex(
                name: "IX_Users_addressId",
                table: "UsersApp",
                newName: "IX_UsersApp_addressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersApp",
                table: "UsersApp",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_UsersApp_UserModelId",
                table: "Albums",
                column: "UserModelId",
                principalTable: "UsersApp",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_UsersApp_UserModelId",
                table: "Posts",
                column: "UserModelId",
                principalTable: "UsersApp",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_UsersApp_UserModelId",
                table: "ToDos",
                column: "UserModelId",
                principalTable: "UsersApp",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersApp_Address_addressId",
                table: "UsersApp",
                column: "addressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_UsersApp_UserModelId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_UsersApp_UserModelId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_UsersApp_UserModelId",
                table: "ToDos");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersApp_Address_addressId",
                table: "UsersApp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersApp",
                table: "UsersApp");

            migrationBuilder.RenameTable(
                name: "UsersApp",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_UsersApp_addressId",
                table: "Users",
                newName: "IX_Users_addressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Users_UserModelId",
                table: "Albums",
                column: "UserModelId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserModelId",
                table: "Posts",
                column: "UserModelId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_Users_UserModelId",
                table: "ToDos",
                column: "UserModelId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Address_addressId",
                table: "Users",
                column: "addressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
