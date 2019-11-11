using Microsoft.EntityFrameworkCore.Migrations;

namespace DabAflevering2.Migrations
{
    public partial class Naan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dish",
                columns: new[] { "DishId", "Price", "ReviewId", "Type" },
                values: new object[] { 6, 30.0, 9, "Naan Broed med smoer" });

            migrationBuilder.InsertData(
                table: "ResturentDishes",
                columns: new[] { "DishId", "ResturentId" },
                values: new object[] { 6, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ResturentDishes",
                keyColumns: new[] { "DishId", "ResturentId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 6);
        }
    }
}
