using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkLath.Model.Migrations
{
    public partial class addedrelationbetweenjobsandposts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Company",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "Postition",
                table: "Jobs");

            migrationBuilder.AddColumn<string>(
                name: "JobId",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobId1",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Jobs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_JobId1",
                table: "Posts",
                column: "JobId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Jobs_JobId1",
                table: "Posts",
                column: "JobId1",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Jobs_JobId1",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_JobId1",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "JobId1",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Jobs");

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postition",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
