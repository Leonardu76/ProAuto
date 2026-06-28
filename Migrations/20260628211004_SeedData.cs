using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProAuto.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Associates",
                columns: new[] { "Id", "CPF", "Name" },
                values: new object[,]
                {
                    { 1, "11111111111", "João Silva" },
                    { 2, "22222222222", "Maria Souza" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AssociateId", "City", "Number", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, 1, "BH", "100", "MG", "Rua A", "30100000" },
                    { 2, 2, "BH", "200", "MG", "Rua B", "30200000" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "AssociateId", "Plate" },
                values: new object[,]
                {
                    { 1, 1, "ABC1234" },
                    { 2, 2, "XYZ9999" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Associates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Associates",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
