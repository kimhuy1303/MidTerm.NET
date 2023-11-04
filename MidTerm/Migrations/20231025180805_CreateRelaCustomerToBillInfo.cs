using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidTerm.Migrations
{
    public partial class CreateRelaCustomerToBillInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "BillInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BillInfos_CustomerId",
                table: "BillInfos",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillInfos_Customers_CustomerId",
                table: "BillInfos",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillInfos_Customers_CustomerId",
                table: "BillInfos");

            migrationBuilder.DropIndex(
                name: "IX_BillInfos_CustomerId",
                table: "BillInfos");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "BillInfos");
        }
    }
}
