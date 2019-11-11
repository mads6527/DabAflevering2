using Microsoft.EntityFrameworkCore.Migrations;

namespace DabAflevering2.Migrations
{
    public partial class måskedetvirker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Table",
                columns: new[] { "TableId", "Number", "ResturentId" },
                values: new object[] { 3, 1, 2 });

            migrationBuilder.InsertData(
                table: "Table",
                columns: new[] { "TableId", "Number", "ResturentId" },
                values: new object[] { 4, 3, 1 });

            migrationBuilder.InsertData(
                table: "Table",
                columns: new[] { "TableId", "Number", "ResturentId" },
                values: new object[] { 5, 2, 2 });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "Discriminator", "Name", "ReviewId", "TableId" },
                values: new object[] { 7, "Guest", "Mathias Det virker", 4, 3 });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "Discriminator", "Name", "ReviewId", "TableId" },
                values: new object[] { 8, "Guest", "Madsemand", 3, 4 });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "Discriminator", "Name", "ReviewId", "TableId" },
                values: new object[] { 9, "Guest", "Mark Løjer", 5, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "TableId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "TableId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "TableId",
                keyValue: 5);
        }
    }
}
