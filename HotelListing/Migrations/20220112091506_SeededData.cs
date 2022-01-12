using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class SeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Name", "Shortname" },
                values: new object[] { 1, "Bangladesh", "BD" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Name", "Shortname" },
                values: new object[] { 2, "United States of America", "US" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Name", "Shortname" },
                values: new object[] { 3, "India", "IN" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "CountryID", "Name", "Rating" },
                values: new object[] { 1, "Dhaka", 1, "Hotel Intercontinental", 4.5 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "CountryID", "Name", "Rating" },
                values: new object[] { 2, "California", 2, "Hotel California", 5.0 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "CountryID", "Name", "Rating" },
                values: new object[] { 3, "New Delhi", 3, "Hotel Taj", 4.2999999999999998 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
