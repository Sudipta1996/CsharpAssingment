using Microsoft.EntityFrameworkCore.Migrations;

namespace Authentication.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "signUps");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "signUps",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
