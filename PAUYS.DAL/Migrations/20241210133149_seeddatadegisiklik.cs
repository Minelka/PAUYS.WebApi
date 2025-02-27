using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAUYS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class seeddatadegisiklik : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6bb387b1-7357-4cd2-ab29-a9819c76c845", "ad43ee03-02de-4b6a-ada6-f276bc6daa92" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bb387b1-7357-4cd2-ab29-a9819c76c845");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad43ee03-02de-4b6a-ada6-f276bc6daa92");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2dc810f-3a6c-41c5-a165-ca12e7b684a4", "27559af2-a10b-439d-9772-499f98da3bed", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "Deleted", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureFileName", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName", "UserType" },
                values: new object[] { "fd9fc1e5-d047-44ae-b55a-ab508ac97290", 0, "27559af2-a10b-439d-9772-499f98da3bed", new DateTime(2024, 12, 10, 16, 31, 48, 878, DateTimeKind.Local).AddTicks(7975), null, "minel.karakokcek@mail.com", true, "Minel", true, false, "Karakökçek", false, null, "MINEL.KARAKOKCEK@MAIL.COM", "MINEL.KARAKOKCEK@MAIL.COM", "AQAAAAIAAYagAAAAEDmPrWYAqaQMNexuSt3SxD6lbx1X44kEMd6yYnocCvcEbN+eAVEMFMEoJfkc6gYeEg==", null, false, "", "27559af2-a10b-439d-9772-499f98da3bed", false, null, "minel.karakokcek@mail.com", 1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e2dc810f-3a6c-41c5-a165-ca12e7b684a4", "fd9fc1e5-d047-44ae-b55a-ab508ac97290" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2dc810f-3a6c-41c5-a165-ca12e7b684a4", "fd9fc1e5-d047-44ae-b55a-ab508ac97290" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2dc810f-3a6c-41c5-a165-ca12e7b684a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9fc1e5-d047-44ae-b55a-ab508ac97290");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6bb387b1-7357-4cd2-ab29-a9819c76c845", "352dc58a-4771-481c-8dbd-86d0b1395f90", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "Deleted", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureFileName", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName", "UserType" },
                values: new object[] { "ad43ee03-02de-4b6a-ada6-f276bc6daa92", 0, "352dc58a-4771-481c-8dbd-86d0b1395f90", new DateTime(2024, 12, 10, 15, 48, 55, 195, DateTimeKind.Local).AddTicks(3355), null, "minel.karakokcek@mail.com", true, "Minel", true, false, "Karakökçek", false, null, "MINEL.KARAKOKCEK@GMAIL.COM", "MINEL.KARAKOKCEK@GMAIL.COM", "AQAAAAIAAYagAAAAEL3BF+VzyxCy7pzPMttYeYSef1VKUrXBU5D8MOBZ7LS1tiK95pqvPsBqmZLsQXMB9g==", null, false, "", "352dc58a-4771-481c-8dbd-86d0b1395f90", false, null, "minel.karakokcek@mail.com", 1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6bb387b1-7357-4cd2-ab29-a9819c76c845", "ad43ee03-02de-4b6a-ada6-f276bc6daa92" });
        }
    }
}
