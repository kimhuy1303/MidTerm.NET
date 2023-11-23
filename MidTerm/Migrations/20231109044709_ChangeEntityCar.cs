using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidTerm.Migrations
{
    public partial class ChangeEntityCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cars",
                newName: "Category");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Cars",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Cars",
                newName: "Description");
        }
    }
}
