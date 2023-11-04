using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidTerm.Migrations
{
    public partial class CreateRelaCarToBillInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "BillInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BillInfos_CarId",
                table: "BillInfos",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillInfos_Cars_CarId",
                table: "BillInfos",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillInfos_Cars_CarId",
                table: "BillInfos");

            migrationBuilder.DropIndex(
                name: "IX_BillInfos_CarId",
                table: "BillInfos");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "BillInfos");
        }
    }
}
