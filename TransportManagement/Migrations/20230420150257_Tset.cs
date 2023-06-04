using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportManagement.Migrations
{
    public partial class Tset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc4e1120-557d-435f-97bc-a84546e50a62", "AQAAAAEAACcQAAAAEMNhlY8fXWUs/Xfqzym5Vrw1y+6ovP+uXzj5dHMnli/bm4fuTC8vm4nlMilbS517cQ==", "dffc9c6a-f7dd-43b4-a249-c25b355d3f75" });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_FuelId",
                table: "Vehicles",
                column: "FuelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Fuels_FuelId",
                table: "Vehicles",
                column: "FuelId",
                principalTable: "Fuels",
                principalColumn: "FuelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Fuels_FuelId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_FuelId",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dd36636-b4d8-4010-8594-caebfbe55991",
                column: "ConcurrencyStamp",
                value: "5abef0a2-8e29-4e00-96c3-10757f2babbc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84572bc3-25fc-4ef8-9056-67c4da04069b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a11d0a3c-45df-463c-b5b9-e04cb0a70583", "AQAAAAEAACcQAAAAEMAQJcrq0MAAR/+TXLoacDQ4OiPk8BRyU9s71T1P28Bw74bUYOU+Wk7WBdzfuuRTPA==", "d1f1401c-602a-4820-8531-34b62b2368c3" });
        }
    }
}
