using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("35441fe6-36c7-497b-987b-e64e86b9dd24"), "Value 101" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("56999560-f91b-4dc1-9302-9145750d34e1"), "Value 102" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("7631503c-3575-47f5-8dda-b8b8ff8b0e3b"), "Value 103" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: new Guid("35441fe6-36c7-497b-987b-e64e86b9dd24"));

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: new Guid("56999560-f91b-4dc1-9302-9145750d34e1"));

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: new Guid("7631503c-3575-47f5-8dda-b8b8ff8b0e3b"));
        }
    }
}
