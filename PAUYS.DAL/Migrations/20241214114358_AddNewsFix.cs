using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAUYS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddNewsFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "News",
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
                    table.PrimaryKey("PK_News", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

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
    }
}
