using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportManagement.Migrations
{
    public partial class Rest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dd36636-b4d8-4010-8594-caebfbe55991",
                column: "ConcurrencyStamp",
                value: "cb9da842-2130-4cda-9e10-7ccd662b15a9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "IsActive", "Name", "NormalizedName", "RolePriority" },
                values: new object[] { "277D668B-264A-433E-9EEB-867C02C6D48D", "7bf384f2-9fbe-47db-930e-5e632a1cc612", true, "Lái xe", "Lái xe", (byte)2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84572bc3-25fc-4ef8-9056-67c4da04069b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62def8d2-164b-4c79-a96e-425c481690f9", "AQAAAAEAACcQAAAAELGfxePuyoWG/5+kYc1A/LCQn+qknodsXMG+vy/f/mR0KjDxpZ7L3FI8PT7RHU+yRg==", "9003b78b-c6f3-415f-bb20-d495c466cc3d" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "Department", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsAvailable", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RolePriority", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6ba7b810-9dad-11d1-80b4-00c04fd430c8}", 0, "facb3595-8562-4556-8f49-10b561de361d.png", "5b47c520-78a7-474b-bc23-fa1ef91fec78", null, null, false, "Driver", true, true, null, "Cheffeur", false, null, null, null, "Driver", "AQAAAAEAACcQAAAAEITpXU9bD+Ud1IjipGP8jgxtudBFlTCzAivr0KcWx03i4TPpQTfmdxoqBrH9SuvVZw==", "0610345992", true, 0, "d77b2387-af80-4873-97f2-22c32178ed78", false, "DRIVER" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "277D668B-264A-433E-9EEB-867C02C6D48D", "6ba7b810-9dad-11d1-80b4-00c04fd430c8}" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "277D668B-264A-433E-9EEB-867C02C6D48D", "6ba7b810-9dad-11d1-80b4-00c04fd430c8}" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "277D668B-264A-433E-9EEB-867C02C6D48D");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ba7b810-9dad-11d1-80b4-00c04fd430c8}");

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
    }
}
