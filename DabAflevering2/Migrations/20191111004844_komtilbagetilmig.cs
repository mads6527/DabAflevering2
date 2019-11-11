using Microsoft.EntityFrameworkCore.Migrations;

namespace DabAflevering2.Migrations
{
    public partial class komtilbagetilmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "Discriminator", "Name" },
                values: new object[,]
                {
                    { 1, "Person", "Mads Jørgensen" },
                    { 2, "Person", "Andreas Elgaard Sørensen" },
                    { 3, "Person", "Mark Højer" },
                    { 4, "Person", "Mathias Jørgensen" }
                });

            migrationBuilder.InsertData(
                table: "Resturent",
                columns: new[] { "ResturentId", "Address", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "fiskergade", "Jerrys", "buffet" },
                    { 2, "Nørreallé 87, 8000", "South India", "Indisk" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "ResturentId", "Stars", "Text" },
                values: new object[,]
                {
                    { 1, 1, 2, "Godt sted" },
                    { 2, 1, 3, "lorte lort" },
                    { 3, 1, 2, "Tyndskid nejtak" },
                    { 6, 1, 3, "Fint til pengene." },
                    { 7, 1, 4, "Mit lokale stamsted!" },
                    { 8, 1, 3, "Kommer her ofte!" },
                    { 4, 2, 2, "Okay, men ikke godt " },
                    { 5, 2, 1, "Kommer aldrig her igen" },
                    { 9, 2, 1, "Nej nej nej" },
                    { 10, 2, 5, "Så lækkert!" }
                });

            migrationBuilder.InsertData(
                table: "Table",
                columns: new[] { "TableId", "Number", "ResturentId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Dish",
                columns: new[] { "DishId", "Price", "ReviewId", "Type" },
                values: new object[,]
                {
                    { 1, 44.0, 1, "Spaghetti Carbonara" },
                    { 2, 75.0, 2, "Pizza med rejer" },
                    { 3, 65.0, 6, "Pizza Peperoni" },
                    { 4, 70.0, 7, "Pizza Meatlover" },
                    { 5, 60.0, 4, "Butter Chicken" },
                    { 7, 40.0, 10, "Tandoori Chicken - Spicy!" }
                });
            /*
            migrationBuilder.InsertData(
                table: "GuestDishes",
                columns: new[] { "DishId", "PersonId" },
                values: new object[] { 1, 5 });*/

            migrationBuilder.InsertData(
                table: "ResturentDishes",
                columns: new[] { "DishId", "ResturentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 2 },
                    { 7, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GuestDishes",
                keyColumns: new[] { "DishId", "PersonId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ResturentDishes",
                keyColumns: new[] { "DishId", "ResturentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ResturentDishes",
                keyColumns: new[] { "DishId", "ResturentId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ResturentDishes",
                keyColumns: new[] { "DishId", "ResturentId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ResturentDishes",
                keyColumns: new[] { "DishId", "ResturentId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ResturentDishes",
                keyColumns: new[] { "DishId", "ResturentId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ResturentDishes",
                keyColumns: new[] { "DishId", "ResturentId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "TableId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "DishId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Resturent",
                keyColumn: "ResturentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resturent",
                keyColumn: "ResturentId",
                keyValue: 2);
        }
    }
}
