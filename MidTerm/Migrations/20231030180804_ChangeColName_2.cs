using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidTerm.Migrations
{
    public partial class ChangeColName_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Features");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Fuels",
                newName: "FuelName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Features",
                newName: "FeatureName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FuelName",
                table: "Fuels",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FeatureName",
                table: "Features",
                newName: "Name");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Features",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
