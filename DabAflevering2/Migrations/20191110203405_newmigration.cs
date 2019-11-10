using Microsoft.EntityFrameworkCore.Migrations;

namespace DabAflevering2.Migrations
{
    public partial class newmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {/*
            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 9);

            migrationBuilder.InsertData(
                table: "Dish",
                columns: new[] { "DishId", "Price", "ReviewId", "Type" },
                values: new object[,]
                {
                    { 1, 44.0, 1, "Spaghetti Carbonara" },
                    { 2, 39.0, 2, "Spaghetti Bolognese" },
                    { 3, 55.0, 3, "Lasagna" },
                    { 4, 60.0, 4, "Spaghetti ala Casa" }
                });*/

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
                columns: new[] { "ResturentId", "Type", "Name", "Address" },
                values: new object[] { 7, "Indisk", "South India", "NørreAllé 47, 8000" }
            );

            migrationBuilder.InsertData(
                table: "Resturent",
                columns: new[] { "ResturentId", "Type", "Name", "Address" },
                values: new object[] { 1, "American", "Burger Boom", "Jægergårdsgade 87, 8000" }
            );

            migrationBuilder.InsertData(
                table: "Resturent",
                columns: new[] { "ResturentId", "Type", "Name", "Address" },
                values: new object[] { 2, "Indisk", "Indian Kitchen", "StreetFood Aarhus, 8000" }
            );

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "ResturentId", "Stars", "Text" },
                values: new object[] { 1, 7, 1, "Fin mad, rigtigt dårlig service" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "ResturentId", "Stars", "Text" },
                values: new object[] { 2, 7, 5, "Maden var perfekt, krydret til perfektion. Dog lidt mangler på service" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "ResturentId", "Stars", "Text" },
                values: new object[] { 3, 1, 4, "Altid godt, men aldrig ekstraordinært" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "ResturentId", "Stars", "Text" },
                values: new object[] { 9, 7, 1, "Mads Jørgensen" });
        }
    }
}
