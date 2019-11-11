using Microsoft.EntityFrameworkCore.Migrations;

namespace DabAflevering2.Migrations
{
    public partial class Carl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Table",
                columns: new[] { "TableId", "Number", "ResturentId" },
                values: new object[] { 2, 2, 1 });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "Discriminator", "Name", "ReviewId", "TableId" },
                values: new object[] { 6, "Guest", "DummeNar", 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "TableId",
                keyValue: 2);
        }
    }
}
