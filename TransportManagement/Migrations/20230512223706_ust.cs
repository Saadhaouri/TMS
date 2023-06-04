using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportManagement.Migrations
{
    public partial class ust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "277D668B-264A-433E-9EEB-867C02C6D48D",
                column: "ConcurrencyStamp",
                value: "ddf54527-18f8-4aff-8539-0da4c55697f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2AA676BC-5BB8-4353-9A62-ABF7533CF2A0",
                columns: new[] { "ConcurrencyStamp", "NormalizedName", "RolePriority" },
                values: new object[] { "dd629553-98bf-4192-9480-70406e785580", "SysAdmin", (byte)3 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dd36636-b4d8-4010-8594-caebfbe55991",
                column: "ConcurrencyStamp",
                value: "aecac16b-22ab-475c-b378-78e7dccfbee3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3F634FF4-4FC5-4387-86DC-AC8E42FBB41A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c32bfa2f-66ec-432a-baa3-8bf3a15d3527", "AQAAAAEAACcQAAAAEGtcH7qB/ZXiA3MtUjNBkbYFeW7gZbOUbzrYdnZJWDwO/LHkJ673+qj2W1WghT0WJA==", "b94980bc-0587-41cf-bc4c-7b447c55e425" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ba7b810-9dad-11d1-80b4-00c04fd430c8}",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9700ca1-8777-46a4-9372-8df8a4040414", "AQAAAAEAACcQAAAAEPzvGqBDohVz/bb/SNJMgw9pu6FhEAkzjAhkIpCNtrsjKD/Hz//Hka5u2nBAQDFIpw==", "cb346047-2a61-4d50-95e9-5b22fb881bc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84572bc3-25fc-4ef8-9056-67c4da04069b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d73b7d6-387c-4b6c-8344-5da68d51a3db", "AQAAAAEAACcQAAAAEHrEsVD1+LQ83yjF076jVPioB2ZDyiJrGv5+QOY7iUJOiBwpOeT9YdneP3XqsOnaRQ==", "adfc945f-9720-4348-aeab-f3f85a722b79" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "277D668B-264A-433E-9EEB-867C02C6D48D",
                column: "ConcurrencyStamp",
                value: "1ffa3868-79a6-420e-84e0-b54104b058e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2AA676BC-5BB8-4353-9A62-ABF7533CF2A0",
                columns: new[] { "ConcurrencyStamp", "NormalizedName", "RolePriority" },
                values: new object[] { "f3a1b609-243d-4794-8f67-cc19b49a0313", "Sys Admin", (byte)2 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dd36636-b4d8-4010-8594-caebfbe55991",
                column: "ConcurrencyStamp",
                value: "a2f34028-224d-48dc-94d5-24e9756c230e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3F634FF4-4FC5-4387-86DC-AC8E42FBB41A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a3055dc-1ddc-434a-9eae-efdd90e73773", "AQAAAAEAACcQAAAAECu1hoUqRjVklz6oAEfjhvH3Dbp2iddNQVVMdiAQmEbGwoJh/hA1HlPRspQDeVZx3A==", "aa3bab4e-15f9-49ba-ac02-cf683fa7744c" });

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
        }
    }
}
