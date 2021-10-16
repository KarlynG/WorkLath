using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkLath.Model.Migrations
{
    public partial class updateddocumentinpost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Documents_PhotoId1",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PhotoId1",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PhotoId1",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "PhotoId",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PhotoId",
                table: "Posts",
                column: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Documents_PhotoId",
                table: "Posts",
                column: "PhotoId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Documents_PhotoId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PhotoId",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "PhotoId",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhotoId1",
                table: "Posts",
                type: "int",
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
        }
    }
}
