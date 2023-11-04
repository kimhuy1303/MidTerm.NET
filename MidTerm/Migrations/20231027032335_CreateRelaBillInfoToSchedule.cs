using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidTerm.Migrations
{
    public partial class CreateRelaBillInfoToSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "BillInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BillInfos_ScheduleId",
                table: "BillInfos",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillInfos_Schedules_ScheduleId",
                table: "BillInfos",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillInfos_Schedules_ScheduleId",
                table: "BillInfos");

            migrationBuilder.DropIndex(
                name: "IX_BillInfos_ScheduleId",
                table: "BillInfos");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "BillInfos");
        }
    }
}
