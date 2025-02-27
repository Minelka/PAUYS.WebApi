using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAUYS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class packingguideadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "PackingGuides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Confirmation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sample = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoldProduction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Finalization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackingGuides", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5fcdb398-d08d-4d34-9378-04dfc5497f07", "6f559774-b34e-43af-941d-579bbc7018f4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "Deleted", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureFileName", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[] { "e780ee50-cdfd-4eea-943e-37d45d087561", 0, "6f559774-b34e-43af-941d-579bbc7018f4", new DateTime(2024, 12, 19, 12, 35, 36, 819, DateTimeKind.Local).AddTicks(9821), null, "minel.karakokcek@mail.com", true, "Minel", true, false, "Karakökçek", false, null, "MINEL.KARAKOKCEK@MAIL.COM", "MINEL.KARAKOKCEK@MAIL.COM", "AQAAAAIAAYagAAAAELDzOmt76kA1KN7VpA8joOUyvyiRk6No8EcdRKyiyVvOLLltco+K9ecp0xajdv3iMw==", null, false, "", "6f559774-b34e-43af-941d-579bbc7018f4", false, null, "minel.karakokcek@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5fcdb398-d08d-4d34-9378-04dfc5497f07", "e780ee50-cdfd-4eea-943e-37d45d087561" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PackingGuides");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5fcdb398-d08d-4d34-9378-04dfc5497f07", "e780ee50-cdfd-4eea-943e-37d45d087561" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fcdb398-d08d-4d34-9378-04dfc5497f07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e780ee50-cdfd-4eea-943e-37d45d087561");

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
    }
}
