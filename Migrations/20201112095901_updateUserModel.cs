using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class updateUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LogInTime",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogOutTime",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogInTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LogOutTime",
                table: "Users");
        }
    }
}
