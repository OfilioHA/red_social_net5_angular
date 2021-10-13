using Microsoft.EntityFrameworkCore.Migrations;

namespace Practica_2.Migrations
{
    public partial class SixthMigratefixinglists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlbumModel_Users_UserModelId",
                table: "AlbumModel");

            migrationBuilder.DropForeignKey(
                name: "FK_PhotoModel_AlbumModel_AlbumModelId",
                table: "PhotoModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhotoModel",
                table: "PhotoModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlbumModel",
                table: "AlbumModel");

            migrationBuilder.RenameTable(
                name: "PhotoModel",
                newName: "Photos");

            migrationBuilder.RenameTable(
                name: "AlbumModel",
                newName: "Albums");

            migrationBuilder.RenameIndex(
                name: "IX_PhotoModel_AlbumModelId",
                table: "Photos",
                newName: "IX_Photos_AlbumModelId");

            migrationBuilder.RenameIndex(
                name: "IX_AlbumModel_UserModelId",
                table: "Albums",
                newName: "IX_Albums_UserModelId");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photos",
                table: "Photos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albums",
                table: "Albums",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Users_UserModelId",
                table: "Albums",
                column: "UserModelId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Albums_AlbumModelId",
                table: "Photos",
                column: "AlbumModelId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Users_UserModelId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Albums_AlbumModelId",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photos",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Albums",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Photos",
                newName: "PhotoModel");

            migrationBuilder.RenameTable(
                name: "Albums",
                newName: "AlbumModel");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_AlbumModelId",
                table: "PhotoModel",
                newName: "IX_PhotoModel_AlbumModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_UserModelId",
                table: "AlbumModel",
                newName: "IX_AlbumModel_UserModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhotoModel",
                table: "PhotoModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlbumModel",
                table: "AlbumModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumModel_Users_UserModelId",
                table: "AlbumModel",
                column: "UserModelId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoModel_AlbumModel_AlbumModelId",
                table: "PhotoModel",
                column: "AlbumModelId",
                principalTable: "AlbumModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
