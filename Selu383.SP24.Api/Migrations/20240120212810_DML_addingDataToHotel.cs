using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Selu383.SP24.Api.Migrations
{
    /// <inheritdoc />
    public partial class DML_addingDataToHotel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Hotels ( Name, Address) VALUES ('HotelName1', 'HotelAddress1')");
            migrationBuilder.Sql("INSERT INTO Hotels ( Name, Address) VALUES ('HotelName2', 'HotelAddress2')");
            migrationBuilder.Sql("INSERT INTO Hotels ( Name, Address) VALUES ('HotelName3', 'HotelAddress3')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
