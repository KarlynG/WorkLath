


using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkLath.Model.Migrations
{
    public partial class updatedpostentityagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Horario",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Schedule",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Schedule",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "Horario",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
