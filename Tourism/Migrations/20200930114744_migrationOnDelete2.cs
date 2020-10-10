using Microsoft.EntityFrameworkCore.Migrations;

namespace Tourism.Migrations
{
    public partial class migrationOnDelete2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoOfPerson",
                table: "packages");

            migrationBuilder.AddColumn<int>(
                name: "NoOfAdults",
                table: "packages",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoOfAdults",
                table: "packages");

            migrationBuilder.AddColumn<int>(
                name: "NoOfPerson",
                table: "packages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
