using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ActivityEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Venue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("2b927ee0-960e-4aba-8030-b60cb9dff7b4"), "Value 101" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e905ebe9-7227-422f-b1b0-97a8dcb78450"), "Value 102" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("94841307-fbcf-4a1d-a4c2-d00ecbdebc7f"), "Value 103" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: new Guid("2b927ee0-960e-4aba-8030-b60cb9dff7b4"));

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: new Guid("94841307-fbcf-4a1d-a4c2-d00ecbdebc7f"));

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: new Guid("e905ebe9-7227-422f-b1b0-97a8dcb78450"));

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
    }
}
