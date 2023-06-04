
using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportManagement.Migrations
{
    public partial class Fuel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "FuelPrice",
                table: "Fuels",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dd36636-b4d8-4010-8594-caebfbe55991",
                column: "ConcurrencyStamp",
                value: "601c72c7-093e-4216-a07f-de976b73b750");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84572bc3-25fc-4ef8-9056-67c4da04069b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f98c11b-12b9-4987-bf61-a245e3f3c091", "AQAAAAEAACcQAAAAEJCYVyFKrkdqmsHR/sLkktu52mDZe3t5vyAmdQbEh2+BpGs6dFk/KbcAJBoovNDv3w==", "3c53950b-05ec-40ae-83ad-aae5b0baddc9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "FuelPrice",
                table: "Fuels",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dd36636-b4d8-4010-8594-caebfbe55991",
                column: "ConcurrencyStamp",
                value: "7b8c3b62-a5da-4212-bb46-740533d96e37");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84572bc3-25fc-4ef8-9056-67c4da04069b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbedb0f6-b044-4b80-9121-71d219215076", "AQAAAAEAACcQAAAAEM0YE2CKLHJXLau5wtPDmwurKpdKyZo3JQyMm9S4SdOGcFnxryopq6VeNtUWJfTERg==", "a9a9f030-5b1c-4c79-ae03-c1787f1f670d" });
        }
    }
}
