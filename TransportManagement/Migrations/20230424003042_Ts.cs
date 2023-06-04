using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportManagement.Migrations
{
    public partial class Ts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "facb3595-8562-4556-8f49-10b561de361d.png", "bbedb0f6-b044-4b80-9121-71d219215076", "AQAAAAEAACcQAAAAEM0YE2CKLHJXLau5wtPDmwurKpdKyZo3JQyMm9S4SdOGcFnxryopq6VeNtUWJfTERg==", "a9a9f030-5b1c-4c79-ae03-c1787f1f670d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dd36636-b4d8-4010-8594-caebfbe55991",
                column: "ConcurrencyStamp",
                value: "5b7f764b-cda2-46ed-8290-c6b9d7c7a171");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84572bc3-25fc-4ef8-9056-67c4da04069b",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "noavatar.png", "dc4e1120-557d-435f-97bc-a84546e50a62", "AQAAAAEAACcQAAAAEMNhlY8fXWUs/Xfqzym5Vrw1y+6ovP+uXzj5dHMnli/bm4fuTC8vm4nlMilbS517cQ==", "dffc9c6a-f7dd-43b4-a249-c25b355d3f75" });
        }
    }
}
