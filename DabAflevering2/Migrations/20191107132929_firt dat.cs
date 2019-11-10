using System;
using DabAflevering2.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DabAflevering2.Migrations
{
    public partial class firtdat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Resturent",
                columns: new[] {"ResturentId", "Type", "Name", "Address"},
                values: new object[] {7,"Indisk", "South India", "NørreAllé 47, 8000"}
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
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 9);
        }
    }
}
