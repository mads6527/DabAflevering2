using Microsoft.EntityFrameworkCore.Migrations;

namespace DabAflevering2.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "ResturentId", "Stars", "Text" },
                values: new object[] { 1, 1, 2, "Godt sted" });

            migrationBuilder.InsertData(
                table: "Dish",
                columns: new[] { "DishId", "Price", "ReviewId", "Type" },
                values: new object[] { 1, 44.0, 1, "Spaghetti Carbonara" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1);
        }
    }
}
