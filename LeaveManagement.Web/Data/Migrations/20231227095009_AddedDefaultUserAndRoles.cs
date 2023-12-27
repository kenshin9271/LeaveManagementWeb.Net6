using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUserAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aed19347-4156-4713-9271-3195703a9bbc", "1e1a150f-ffa2-4ba3-959c-1bea08a32b78", "Administrator", "ADMINISTRATOR" },
                    { "aed19347-4156-4713-9272-3195703a9bbd", "ff623185-fd61-4c01-a62b-ce5068900bf7", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "aed19347-4156-4713-9271-9115703a9bbc", 0, "f182b5a4-aae3-45ae-b569-f3b652bc1b63", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJzX5QEVwfu2WdFLxdwnIHpe8lvZ/XKb94mosT1Os2wpI2Wmbi2Ij1NhX8WMZgbeFw==", null, false, "b38e158f-69d1-45b0-b3bc-c2ed68ad2e27", null, false, "admin@localhost.com" },
                    { "bc8f9cbb-3cae-43f6-a04e-0506c7a96120", 0, "ff0388c6-004b-42d8-9fdf-d14f4d3241e9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEDIosgwDokN+ERcaCdGM7m6nSIkuf9veYISpeHOHbTbE/D4LIBN1m8+KPyiJ/IdbIg==", null, false, "8aef70dc-2f69-40ec-9abe-354c2dc0ece5", null, false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "aed19347-4156-4713-9271-3195703a9bbc", "aed19347-4156-4713-9271-9115703a9bbc" },
                    { "aed19347-4156-4713-9272-3195703a9bbd", "bc8f9cbb-3cae-43f6-a04e-0506c7a96120" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aed19347-4156-4713-9271-3195703a9bbc", "aed19347-4156-4713-9271-9115703a9bbc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aed19347-4156-4713-9272-3195703a9bbd", "bc8f9cbb-3cae-43f6-a04e-0506c7a96120" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aed19347-4156-4713-9271-3195703a9bbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aed19347-4156-4713-9272-3195703a9bbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aed19347-4156-4713-9271-9115703a9bbc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc8f9cbb-3cae-43f6-a04e-0506c7a96120");
        }
    }
}
