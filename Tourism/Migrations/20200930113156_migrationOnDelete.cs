using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tourism.Migrations
{
    public partial class migrationOnDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_users_userId",
                table: "UserRoles");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "UserRoles",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_userId",
                table: "UserRoles",
                newName: "IX_UserRoles_UserId");

            migrationBuilder.CreateTable(
                name: "packages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Destination = table.Column<string>(nullable: true),
                    UserRoleId = table.Column<int>(nullable: false),
                    NoOfPerson = table.Column<int>(nullable: false),
                    NoOfChild = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_packages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_packages_UserRoles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "UserRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageAmount = table.Column<decimal>(nullable: false),
                    Duration = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    BookingAmount = table.Column<decimal>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    GrossAmount = table.Column<decimal>(nullable: false),
                    GST = table.Column<decimal>(nullable: false),
                    NetAmount = table.Column<decimal>(nullable: false),
                    TotalPaid = table.Column<decimal>(nullable: false),
                    BalanceAmount = table.Column<decimal>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    BookingLastDate = table.Column<DateTime>(nullable: false),
                    PackageId = table.Column<int>(nullable: false),
                    UserRoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "packages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_UserRoles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "UserRoles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PackageId",
                table: "Bookings",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserRoleId",
                table: "Bookings",
                column: "UserRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_packages_UserRoleId",
                table: "packages",
                column: "UserRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_users_UserId",
                table: "UserRoles");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "packages");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserRoles",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                newName: "IX_UserRoles_userId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_users_userId",
                table: "UserRoles",
                column: "userId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
