using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidTerm.Migrations
{
    public partial class addPropBillTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "Bills",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Deposit",
                table: "Bills",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "Deposit",
                table: "Bills");
        }
    }
}
