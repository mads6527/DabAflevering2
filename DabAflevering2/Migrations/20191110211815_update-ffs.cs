using Microsoft.EntityFrameworkCore.Migrations;

namespace DabAflevering2.Migrations
{
    public partial class updateffs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Resturent",
                columns: new[] { "ResturentId", "Address", "Name", "Type" },
                values: new object[] { 1, "NørreAllé 47, 8000", "South India", "Indisk" });

            migrationBuilder.InsertData(
                table: "Resturent",
                columns: new[] { "ResturentId", "Address", "Name", "Type" },
                values: new object[] { 2, "Jægergårdsgade 87, 8000", "Burger Boom", "American" });

            migrationBuilder.InsertData(
                table: "Resturent",
                columns: new[] { "ResturentId", "Address", "Name", "Type" },
                values: new object[] { 3, "StreetFood Aarhus, 8000", "Indian Kitchen", "Indisk" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "ResturentId", "Stars", "Text" },
                values: new object[,]
                {
                    { 1, 1, 1, "Fin mad, rigtigt dårlig service" },
                    { 2, 2, 4, "Maden var perfekt, krydret til perfektion. Dog lidt mangler på service" },
                    /*{ 4, 1, 1, "Det pureste lort.." },
                    { 5, 1, 2, "Okay, men langt fra godt..." },*/
                    { 3, 3, 3, "Altid godt, men aldrig ekstraordinært" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resturent",
                keyColumn: "ResturentId",
                keyValue: 2);

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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Resturent",
                keyColumn: "ResturentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resturent",
                keyColumn: "ResturentId",
                keyValue: 3);
        }
    }
}
