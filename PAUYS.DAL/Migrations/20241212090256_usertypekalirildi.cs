using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAUYS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class usertypekalirildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe7b81da-3ac1-48e4-8404-2e643361464f", "0f236956-9999-44e3-b471-efa22652cce9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "Deleted", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureFileName", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[] { "1745ca29-57b4-4901-b829-38626bfd9989", 0, "0f236956-9999-44e3-b471-efa22652cce9", new DateTime(2024, 12, 12, 12, 2, 56, 82, DateTimeKind.Local).AddTicks(6690), null, "minel.karakokcek@mail.com", true, "Minel", true, false, "Karakökçek", false, null, "MINEL.KARAKOKCEK@MAIL.COM", "MINEL.KARAKOKCEK@MAIL.COM", "AQAAAAIAAYagAAAAEMpuNlvFIFHo+nYhPmn22/eiDdLnLPnXKOHg55q4kYLiA6iQ3CQah7Px3GlnzZG8CA==", null, false, "", "0f236956-9999-44e3-b471-efa22652cce9", false, null, "minel.karakokcek@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fe7b81da-3ac1-48e4-8404-2e643361464f", "1745ca29-57b4-4901-b829-38626bfd9989" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fe7b81da-3ac1-48e4-8404-2e643361464f", "1745ca29-57b4-4901-b829-38626bfd9989" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe7b81da-3ac1-48e4-8404-2e643361464f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1745ca29-57b4-4901-b829-38626bfd9989");

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
