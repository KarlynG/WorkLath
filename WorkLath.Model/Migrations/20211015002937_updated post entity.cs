using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkLath.Model.Migrations
{
    public partial class updatedpostentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Documents_PhotoId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "PhotoId",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Horario",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoId",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhotoId1",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Posts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PhotoId1",
                table: "Posts",
                column: "PhotoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Documents_PhotoId1",
                table: "Posts",
                column: "PhotoId1",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Documents_PhotoId",
                table: "Users",
                column: "PhotoId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Documents_PhotoId1",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Documents_PhotoId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PhotoId1",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Horario",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PhotoId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PhotoId1",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "PhotoId",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Documents_PhotoId",
                table: "Users",
                column: "PhotoId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
