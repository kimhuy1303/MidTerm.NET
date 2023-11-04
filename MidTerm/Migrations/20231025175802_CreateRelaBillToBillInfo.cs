using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidTerm.Migrations
{
    public partial class CreateRelaBillToBillInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BillId",
                table: "BillInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BillInfos_BillId",
                table: "BillInfos",
                column: "BillId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BillInfos_Bills_BillId",
                table: "BillInfos",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillInfos_Bills_BillId",
                table: "BillInfos");

            migrationBuilder.DropIndex(
                name: "IX_BillInfos_BillId",
                table: "BillInfos");

            migrationBuilder.DropColumn(
                name: "BillId",
                table: "BillInfos");
        }
    }
}
