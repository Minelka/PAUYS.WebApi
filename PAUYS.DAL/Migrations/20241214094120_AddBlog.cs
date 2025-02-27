using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAUYS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddBlog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "CustomerMessege",
                table: "CustomerRequest",
                newName: "CustomerMessage");

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PictureFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

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

            migrationBuilder.RenameColumn(
                name: "CustomerMessage",
                table: "CustomerRequest",
                newName: "CustomerMessege");

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
    }
}
