using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProAuto.Migrations
{
    /// <inheritdoc />
    public partial class AddPhoneToAssociate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Associates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Associates",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phone",
                value: "5531988888888");

            migrationBuilder.UpdateData(
                table: "Associates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phone",
                value: "5531999999999");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Associates");
        }
    }
}
