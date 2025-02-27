using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAUYS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class sssadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54b7e87f-a394-4e5a-80ec-ec157e6604c6", "35864559-1f76-4eb9-97ec-3fd23ce936c6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54b7e87f-a394-4e5a-80ec-ec157e6604c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35864559-1f76-4eb9-97ec-3fd23ce936c6");

            migrationBuilder.CreateTable(
                name: "Questionss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Questions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionss", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ae25f4fb-389d-4eb1-a6cf-f2ff319a1f40", "2fb2d427-f42b-4071-8665-bed404a8be8b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "Deleted", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureFileName", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[] { "ce59f992-45b6-477b-85c6-98e94c353626", 0, "2fb2d427-f42b-4071-8665-bed404a8be8b", new DateTime(2024, 12, 17, 18, 53, 57, 602, DateTimeKind.Local).AddTicks(6281), null, "minel.karakokcek@mail.com", true, "Minel", true, false, "Karakökçek", false, null, "MINEL.KARAKOKCEK@MAIL.COM", "MINEL.KARAKOKCEK@MAIL.COM", "AQAAAAIAAYagAAAAEM+0lGHveJvorB7qGNETV6yD2k0LF0lPcp1d4NJwb8nKHKscJ9aKpKbhjiTqFL5/1Q==", null, false, "", "2fb2d427-f42b-4071-8665-bed404a8be8b", false, null, "minel.karakokcek@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ae25f4fb-389d-4eb1-a6cf-f2ff319a1f40", "ce59f992-45b6-477b-85c6-98e94c353626" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questionss");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ae25f4fb-389d-4eb1-a6cf-f2ff319a1f40", "ce59f992-45b6-477b-85c6-98e94c353626" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae25f4fb-389d-4eb1-a6cf-f2ff319a1f40");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce59f992-45b6-477b-85c6-98e94c353626");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "54b7e87f-a394-4e5a-80ec-ec157e6604c6", "8650f85e-7acb-445b-9480-592f0fda4f1e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "Deleted", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureFileName", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[] { "35864559-1f76-4eb9-97ec-3fd23ce936c6", 0, "8650f85e-7acb-445b-9480-592f0fda4f1e", new DateTime(2024, 12, 14, 14, 43, 58, 102, DateTimeKind.Local).AddTicks(2279), null, "minel.karakokcek@mail.com", true, "Minel", true, false, "Karakökçek", false, null, "MINEL.KARAKOKCEK@MAIL.COM", "MINEL.KARAKOKCEK@MAIL.COM", "AQAAAAIAAYagAAAAEAdi8xnFKMwq0Yy7wN6rhibpcwTiVxSHk7qyG1OrHjwMDdnWZcBL5RXeEwrM7qbaQQ==", null, false, "", "8650f85e-7acb-445b-9480-592f0fda4f1e", false, null, "minel.karakokcek@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "54b7e87f-a394-4e5a-80ec-ec157e6604c6", "35864559-1f76-4eb9-97ec-3fd23ce936c6" });
        }
    }
}
