using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportManagement.Migrations
{
    public partial class us : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                value: "1ffa3868-79a6-420e-84e0-b54104b058e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dd36636-b4d8-4010-8594-caebfbe55991",
                column: "ConcurrencyStamp",
                value: "a2f34028-224d-48dc-94d5-24e9756c230e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "IsActive", "Name", "NormalizedName", "RolePriority" },
                values: new object[] { "2AA676BC-5BB8-4353-9A62-ABF7533CF2A0", "f3a1b609-243d-4794-8f67-cc19b49a0313", true, "Saad", "Sys Admin", (byte)2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ba7b810-9dad-11d1-80b4-00c04fd430c8}",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1477b060-b3c6-43f6-93ca-42db560dc73c", "AQAAAAEAACcQAAAAEB1bYpnHwpwY4+i3uKL4Ru8DZL9AhLigmYLsq2/zWdIn+AmcD3HZm8sgu3NQwoDW6A==", "f1936c09-3f5b-4af6-97df-3bb2fb97a0f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84572bc3-25fc-4ef8-9056-67c4da04069b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "433c8bd5-a91c-4de6-8d48-69f55d12a526", "AQAAAAEAACcQAAAAEL5D2CE04ukn0MmFLjbbTtuqzQQGfE54RHcRCEbu5U03nSqwynjYRwW0NdRUZh2znw==", "c7f01574-dc87-44ca-8e93-86db4c3d981f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "Department", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsAvailable", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RolePriority", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3F634FF4-4FC5-4387-86DC-AC8E42FBB41A", 0, "download (1).jpg", "6a3055dc-1ddc-434a-9eae-efdd90e73773", null, null, false, "Saad ", true, true, null, "Haouri", false, null, null, null, "Karim", "AQAAAAEAACcQAAAAECu1hoUqRjVklz6oAEfjhvH3Dbp2iddNQVVMdiAQmEbGwoJh/hA1HlPRspQDeVZx3A==", "0766444205", true, 0, "aa3bab4e-15f9-49ba-ac02-cf683fa7744c", false, "Haouri" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2AA676BC-5BB8-4353-9A62-ABF7533CF2A0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3F634FF4-4FC5-4387-86DC-AC8E42FBB41A");

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
        }
    }
}
