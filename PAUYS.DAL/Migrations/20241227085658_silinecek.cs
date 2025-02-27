using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAUYS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class silinecek : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ea014995-f7e2-49bf-9673-bc72775e61c5", "5f1c93ec-d4b9-476a-b9ed-5286bc24174c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea014995-f7e2-49bf-9673-bc72775e61c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f1c93ec-d4b9-476a-b9ed-5286bc24174c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a04d1cc0-7bd7-486d-a66e-b243ea5ab738", "c0886c41-3542-4a87-b5aa-08f1b3b530a6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "Deleted", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureFileName", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[] { "07dc1dd6-b906-47b0-b721-ba8668029a4b", 0, "c0886c41-3542-4a87-b5aa-08f1b3b530a6", new DateTime(2024, 12, 27, 11, 56, 58, 283, DateTimeKind.Local).AddTicks(9605), null, "minel.karakokcek@mail.com", true, "Minel", true, false, "Karakökçek", false, null, "MINEL.KARAKOKCEK@MAIL.COM", "MINEL.KARAKOKCEK@MAIL.COM", "AQAAAAIAAYagAAAAEENAJIyiTJAp4EQGXiW9F+ZLlx0ZsuL91sJFUnhk745nmqGqdSS4s5vH2Gn4D/K6ug==", null, false, "", "c0886c41-3542-4a87-b5aa-08f1b3b530a6", false, null, "minel.karakokcek@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a04d1cc0-7bd7-486d-a66e-b243ea5ab738", "07dc1dd6-b906-47b0-b721-ba8668029a4b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a04d1cc0-7bd7-486d-a66e-b243ea5ab738", "07dc1dd6-b906-47b0-b721-ba8668029a4b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a04d1cc0-7bd7-486d-a66e-b243ea5ab738");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07dc1dd6-b906-47b0-b721-ba8668029a4b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea014995-f7e2-49bf-9673-bc72775e61c5", "153ec468-46b8-4caf-851b-70e3f5ba7bc4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "Deleted", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureFileName", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[] { "5f1c93ec-d4b9-476a-b9ed-5286bc24174c", 0, "153ec468-46b8-4caf-851b-70e3f5ba7bc4", new DateTime(2024, 12, 27, 11, 51, 44, 429, DateTimeKind.Local).AddTicks(7570), null, "minel.karakokcek@mail.com", true, "Minel", true, false, "Karakökçek", false, null, "MINEL.KARAKOKCEK@MAIL.COM", "MINEL.KARAKOKCEK@MAIL.COM", "AQAAAAIAAYagAAAAEMGNPq61CYsgwcWCXOijs6vTJWF22iDkgWU0I9FGHsxu3quwnMjpAzBmti1AztkWjQ==", null, false, "", "153ec468-46b8-4caf-851b-70e3f5ba7bc4", false, null, "minel.karakokcek@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ea014995-f7e2-49bf-9673-bc72775e61c5", "5f1c93ec-d4b9-476a-b9ed-5286bc24174c" });
        }
    }
}
