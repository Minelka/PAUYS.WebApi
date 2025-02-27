using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAUYS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddNews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "93d62f1a-4529-4be4-8f75-bfaac82d0d6b", "b3038fd3-731f-42cf-8885-ca7932bb544c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93d62f1a-4529-4be4-8f75-bfaac82d0d6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3038fd3-731f-42cf-8885-ca7932bb544c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77d80781-5254-4b98-9ee6-375e404e20be", "031ce341-9742-496b-8561-03eec4371d51", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "Deleted", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureFileName", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[] { "2d2e387e-5c8d-4fc7-a8a5-1b8a6a329ba9", 0, "031ce341-9742-496b-8561-03eec4371d51", new DateTime(2024, 12, 14, 14, 40, 25, 483, DateTimeKind.Local).AddTicks(7233), null, "minel.karakokcek@mail.com", true, "Minel", true, false, "Karakökçek", false, null, "MINEL.KARAKOKCEK@MAIL.COM", "MINEL.KARAKOKCEK@MAIL.COM", "AQAAAAIAAYagAAAAENCHcFO6tgFZcPnaQGZKVLunAz7c4m4l/rqE7IwBO5Ai6rOFI5wFDWb72wPh4aoOaA==", null, false, "", "031ce341-9742-496b-8561-03eec4371d51", false, null, "minel.karakokcek@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "77d80781-5254-4b98-9ee6-375e404e20be", "2d2e387e-5c8d-4fc7-a8a5-1b8a6a329ba9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "77d80781-5254-4b98-9ee6-375e404e20be", "2d2e387e-5c8d-4fc7-a8a5-1b8a6a329ba9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77d80781-5254-4b98-9ee6-375e404e20be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d2e387e-5c8d-4fc7-a8a5-1b8a6a329ba9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93d62f1a-4529-4be4-8f75-bfaac82d0d6b", "57660a98-ac70-46cd-8029-9c67c45f48a6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "Deleted", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureFileName", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[] { "b3038fd3-731f-42cf-8885-ca7932bb544c", 0, "57660a98-ac70-46cd-8029-9c67c45f48a6", new DateTime(2024, 12, 14, 12, 41, 20, 436, DateTimeKind.Local).AddTicks(524), null, "minel.karakokcek@mail.com", true, "Minel", true, false, "Karakökçek", false, null, "MINEL.KARAKOKCEK@MAIL.COM", "MINEL.KARAKOKCEK@MAIL.COM", "AQAAAAIAAYagAAAAEFe/Qj53F2B8QhX3gOO6pzvr18GWQHvQrnVyxDH/NTxE75J/PeXdOK/0pHsaM/h0bA==", null, false, "", "57660a98-ac70-46cd-8029-9c67c45f48a6", false, null, "minel.karakokcek@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "93d62f1a-4529-4be4-8f75-bfaac82d0d6b", "b3038fd3-731f-42cf-8885-ca7932bb544c" });
        }
    }
}
