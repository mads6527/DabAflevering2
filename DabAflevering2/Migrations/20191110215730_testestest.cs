using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DabAflevering2.Migrations
{
    public partial class testestest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "Person");

            migrationBuilder.InsertData(
                table: "Table",
                columns: new[] { "TableId", "Number", "ResturentId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "Discriminator", "Name", "ReviewId", "TableId" },
                values: new object[] { 5, "Guest", null, null, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "TableId",
                keyValue: 1);

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "Person",
                nullable: true);
        }
    }
}
