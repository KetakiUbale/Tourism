using Microsoft.EntityFrameworkCore.Migrations;

namespace Tourism.Migrations
{
    public partial class migrationover : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pincode",
                table: "users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Pincode",
                table: "users");
        }
    }
}
