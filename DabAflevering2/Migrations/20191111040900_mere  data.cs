using Microsoft.EntityFrameworkCore.Migrations;

namespace DabAflevering2.Migrations
{
    public partial class meredata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dish",
                columns: new[] { "DishId", "Price", "ReviewId", "Type" },
                values: new object[,]
                {
                    { 8, 20.0, 11, "Smurt håndværker med pålæg" },
                    { 9, 5.0, 12, "Sort kaffe uden mælk" },
                    { 10, 250.0, 13, "Fri sushi" },
                    { 11, 120.0, 14, "10 stk. valgfri sushi" },
                    { 12, 12.0, 15, "fransk Hotdog" },
                    { 13, 25.0, 16, "Flæskestegs Sandwich" },
                    { 14, 25.0, 17, "Rugbrøds Sandwich" }
                });

            migrationBuilder.InsertData(
                table: "ResturentDishes",
                columns: new[] { "DishId", "ResturentId" },
                values: new object[,]
                {
                    { 8, 3 },
                    { 9, 3 },
                    { 10, 4 },
                    { 11, 4 },
                    { 12, 5 },
                    { 13, 5 },
                    { 14, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ResturentDishes",
                keyColumns: new[] { "DishId", "ResturentId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "ResturentDishes",
                keyColumns: new[] { "DishId", "ResturentId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "ResturentDishes",
                keyColumns: new[] { "DishId", "ResturentId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "ResturentDishes",
                keyColumns: new[] { "DishId", "ResturentId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "ResturentDishes",
                keyColumns: new[] { "DishId", "ResturentId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "ResturentDishes",
                keyColumns: new[] { "DishId", "ResturentId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "ResturentDishes",
                keyColumns: new[] { "DishId", "ResturentId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 14);
        }
    }
}
