using Microsoft.EntityFrameworkCore.Migrations;

namespace DabAflevering2.Migrations
{
    public partial class testtest : Migration
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
                values: new object[] { 1, "fiskergade", "Jerrys", "buffet" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Resturent",
                keyColumn: "ResturentId",
                keyValue: 1);
        }
    }
}
