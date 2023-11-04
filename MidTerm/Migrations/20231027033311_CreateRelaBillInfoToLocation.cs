using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidTerm.Migrations
{
    public partial class CreateRelaBillInfoToLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationId",
                table: "BillInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BillInfos_DestinationId",
                table: "BillInfos",
                column: "DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillInfos_Locations_DestinationId",
                table: "BillInfos",
                column: "DestinationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillInfos_Locations_DestinationId",
                table: "BillInfos");

            migrationBuilder.DropIndex(
                name: "IX_BillInfos_DestinationId",
                table: "BillInfos");

            migrationBuilder.DropColumn(
                name: "DestinationId",
                table: "BillInfos");
        }
    }
}
