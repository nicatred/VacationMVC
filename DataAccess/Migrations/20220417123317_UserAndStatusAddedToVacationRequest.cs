using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class UserAndStatusAddedToVacationRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "VacationRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "VacationRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VacationRequestStatus",
                table: "VacationRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VacationRequests_UserId",
                table: "VacationRequests",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_VacationRequests_Users_UserId",
                table: "VacationRequests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacationRequests_Users_UserId",
                table: "VacationRequests");

            migrationBuilder.DropIndex(
                name: "IX_VacationRequests_UserId",
                table: "VacationRequests");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "VacationRequests");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "VacationRequests");

            migrationBuilder.DropColumn(
                name: "VacationRequestStatus",
                table: "VacationRequests");
        }
    }
}
