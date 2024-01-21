using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Selu383.SP24.Api.Migrations
{
    /// <inheritdoc />
    public partial class addData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { 5, "Location A", "Hotel A" },
                    { 6, "Location B", "Hotel B" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
