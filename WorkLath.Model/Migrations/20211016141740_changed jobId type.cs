using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkLath.Model.Migrations
{
    public partial class changedjobIdtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Jobs_JobId1",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_JobId1",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "JobId1",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_JobId",
                table: "Posts",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Jobs_JobId",
                table: "Posts",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Jobs_JobId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_JobId",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "JobId",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "JobId1",
                table: "Posts",
                type: "int",
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
    }
}
