using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidTerm.Migrations
{
    public partial class addFKBillFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<double>(
                name: "FeaturePrice",
                table: "Features",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "BillFeature",
                columns: table => new
                {
                    BillsId = table.Column<int>(type: "int", nullable: false),
                    FeaturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillFeature", x => new { x.BillsId, x.FeaturesId });
                    table.ForeignKey(
                        name: "FK_BillFeature_Bills_BillsId",
                        column: x => x.BillsId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillFeature_Features_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillFeature_FeaturesId",
                table: "BillFeature",
                column: "FeaturesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillFeature");

            migrationBuilder.DropColumn(
                name: "FeaturePrice",
                table: "Features");

            migrationBuilder.CreateTable(
                name: "FeatureCar",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureCar", x => new { x.CarId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_FeatureCar_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeatureCar_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeatureCar_FeatureId",
                table: "FeatureCar",
                column: "FeatureId");
        }
    }
}
