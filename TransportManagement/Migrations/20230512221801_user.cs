using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportManagement.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "277D668B-264A-433E-9EEB-867C02C6D48D",
                column: "ConcurrencyStamp",
                value: "bceb558b-f57f-49e6-80ab-613ba2298d3e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dd36636-b4d8-4010-8594-caebfbe55991",
                column: "ConcurrencyStamp",
                value: "7873841e-d09b-4a0c-a617-05dab2d864c1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "IsActive", "Name", "NormalizedName", "RolePriority" },
                values: new object[] { "276D668B-264A-433E-9EEB-867C02C6D48D", "1788d30a-6fb7-4bc2-92e5-dd1ccb768a59", true, "Admin", "Admin", (byte)2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ba7b810-9dad-11d1-80b4-00c04fd430c8}",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53e6566a-e700-448d-af71-a5e0d7928b1a", "AQAAAAEAACcQAAAAEAvm8OkxTbxE4jI1KrlBQVAUiCLbc4YGdS86cHIEOmf7QBx2KWTIgIMVjmxgEqdqRw==", "b93e6e1a-acb5-422c-969e-4dd0566cfe10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84572bc3-25fc-4ef8-9056-67c4da04069b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d503b679-bef5-4119-b6fb-f7cc5903ce7c", "AQAAAAEAACcQAAAAEOnlLiIwsl7psKfwt6JaDj/hyWps4H/nD10udODOty7vRJvH6otCU3RRU8HSciOZSw==", "19b1c510-0db5-4d86-9ada-cbd835f9e38c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "Department", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsAvailable", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RolePriority", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7ba7b810-5dad-11d1-81b4-80c04fd430r8", 0, "download (1).jpg", "e3fd6026-96ee-4196-90d8-c4bd182f2225", null, null, false, "Saad ", true, true, null, "Haouri", false, null, null, null, "Admin", "AQAAAAEAACcQAAAAEK0MyWkBAmuDKmgCRPeI8uYbGnuLaAQ0RcxYH9S1PMQ74qcSzR/kXDWxJLyQhp+EMQ==", "0610345992", true, 0, "890b9b5e-1fbc-428d-a57d-ad04436e195e", false, "Haouri" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "276D668B-264A-433E-9EEB-867C02C6D48D", "7ba7b810-5dad-11d1-81b4-80c04fd430r8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "276D668B-264A-433E-9EEB-867C02C6D48D", "7ba7b810-5dad-11d1-81b4-80c04fd430r8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "276D668B-264A-433E-9EEB-867C02C6D48D");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ba7b810-5dad-11d1-81b4-80c04fd430r8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "277D668B-264A-433E-9EEB-867C02C6D48D",
                column: "ConcurrencyStamp",
                value: "7bf384f2-9fbe-47db-930e-5e632a1cc612");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dd36636-b4d8-4010-8594-caebfbe55991",
                column: "ConcurrencyStamp",
                value: "cb9da842-2130-4cda-9e10-7ccd662b15a9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ba7b810-9dad-11d1-80b4-00c04fd430c8}",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b47c520-78a7-474b-bc23-fa1ef91fec78", "AQAAAAEAACcQAAAAEITpXU9bD+Ud1IjipGP8jgxtudBFlTCzAivr0KcWx03i4TPpQTfmdxoqBrH9SuvVZw==", "d77b2387-af80-4873-97f2-22c32178ed78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84572bc3-25fc-4ef8-9056-67c4da04069b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62def8d2-164b-4c79-a96e-425c481690f9", "AQAAAAEAACcQAAAAELGfxePuyoWG/5+kYc1A/LCQn+qknodsXMG+vy/f/mR0KjDxpZ7L3FI8PT7RHU+yRg==", "9003b78b-c6f3-415f-bb20-d495c466cc3d" });
        }
    }
}
