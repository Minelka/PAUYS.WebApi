﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAUYS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class appuserentity_authcontroller_adminseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);
        }
    }
}
