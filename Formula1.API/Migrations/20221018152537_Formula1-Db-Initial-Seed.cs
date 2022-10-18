using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Formula1.API.Migrations
{
    public partial class Formula1DbInitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Ferrari Racing Team", "Ferrari" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Mercedes Racing Team", "Mercedes" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Red Bull Racing Team", "Red Bull" });

            migrationBuilder.InsertData(
                table: "TeamLocations",
                columns: new[] { "Id", "Description", "Location", "TeamsId" },
                values: new object[] { 1, "The location of Ferrari Racing Team", "Monza", 1 });

            migrationBuilder.InsertData(
                table: "TeamLocations",
                columns: new[] { "Id", "Description", "Location", "TeamsId" },
                values: new object[] { 2, "The location of Mercedes Racing Team", "Nürburgring", 2 });

            migrationBuilder.InsertData(
                table: "TeamLocations",
                columns: new[] { "Id", "Description", "Location", "TeamsId" },
                values: new object[] { 3, "The location of Red Bull Racing Team", "Zandvoort", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamLocations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeamLocations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TeamLocations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
