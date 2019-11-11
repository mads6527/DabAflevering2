using Microsoft.EntityFrameworkCore.Migrations;

namespace DabAflevering2.Migrations
{
    public partial class nu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 5,
                column: "Name",
                value: "Benjamin");

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 6,
                column: "Name",
                value: "Martin");

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 7,
                column: "Name",
                value: "Mathias");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "Text",
                value: "Det er okay");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "Text",
                value: "Kan bstemt ikke anbefale dette");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 5,
                column: "Name",
                value: "Faggot");

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 6,
                column: "Name",
                value: "DummeNar");

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 7,
                column: "Name",
                value: "Mathias Det virker");

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

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "Text",
                value: "lorte lort");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "Text",
                value: "Tyndskid nejtak");
        }
    }
}
