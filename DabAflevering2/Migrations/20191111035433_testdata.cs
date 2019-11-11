using Microsoft.EntityFrameworkCore.Migrations;

namespace DabAflevering2.Migrations
{
    public partial class testdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resturent",
                keyColumn: "ResturentId",
                keyValue: 1,
                columns: new[] { "Address", "Type" },
                values: new object[] { "Fiskergade 2, 8000", "Buffet" });

            migrationBuilder.UpdateData(
                table: "Resturent",
                keyColumn: "ResturentId",
                keyValue: 2,
                column: "Type",
                value: "Aftensmad");

            migrationBuilder.InsertData(
                table: "Resturent",
                columns: new[] { "ResturentId", "Address", "Name", "Type" },
                values: new object[,]
                {
                    { 3, "Møllevangsallé 22, 8200", "Cafe Alberts", "Morgenmad" },
                    { 4, "Damvej 1, 6100", "Running Sushi", "Buffet" },
                    { 5, "Findlandsgade 142, 8200", "Føtex StorcenterNord", "Frokost" }
                });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "Text",
                value: "Kan bestemt ikke anbefale dette");

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "ResturentId", "Stars", "Text" },
                values: new object[,]
                {
                    { 11, 3, 3, "God smurt rundstyk, rigtig dejligt!" },
                    { 12, 3, 5, "Dårlig servering, kold kaffe 0 stjerner herfra" },
                    { 13, 4, 5, "Super lækkert med frisk fisk!" },
                    { 14, 4, 1, "Fik kolera, og vildt dårlig mave dagen efter et besøg. Anbefalder ikke dette sted til min væreste fjende.." },
                    { 15, 5, 5, "Den bedste franske hotdog i byen, perfekt frokost!" },
                    { 16, 5, 5, "Selvom niveauet er faldet efter flytningen, er det stadig super lækkert, og de har en god sandwich" },
                    { 17, 5, 5, "Ikke få deres karry sauce i jeres sandwich, den smager af bæ.." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Resturent",
                keyColumn: "ResturentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resturent",
                keyColumn: "ResturentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Resturent",
                keyColumn: "ResturentId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Resturent",
                keyColumn: "ResturentId",
                keyValue: 1,
                columns: new[] { "Address", "Type" },
                values: new object[] { "fiskergade", "buffet" });

            migrationBuilder.UpdateData(
                table: "Resturent",
                keyColumn: "ResturentId",
                keyValue: 2,
                column: "Type",
                value: "Indisk");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "Text",
                value: "Kan bstemt ikke anbefale dette");
        }
    }
}
