using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingPeriodToAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aed19347-4156-4713-9271-3195703a9bbc",
                column: "ConcurrencyStamp",
                value: "29cb1416-7781-4272-b77e-6220d728961a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aed19347-4156-4713-9272-3195703a9bbd",
                column: "ConcurrencyStamp",
                value: "fe761402-84e5-4ae7-80f0-b624cb620a44");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aed19347-4156-4713-9271-9115703a9bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c60d4421-4010-4832-a832-2f62a07d662f", "AQAAAAEAACcQAAAAEDdaz3krC0cyPpLR9Wrzi//hc/10vht/IE8Kni/mOBLpwf1JpPAipYtmoNWW32k7xw==", "6bd303ce-4b39-408e-ab02-a49c0043ae6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc8f9cbb-3cae-43f6-a04e-0506c7a96120",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1729e97f-31df-4e69-b82e-93e66a8d9b67", "AQAAAAEAACcQAAAAEMSzFCnZbhobIY/GYjRFbkDQNg9fcA6QxGtkN4K+edQ/GPrwSCLo8kzg+rhhVGRsYQ==", "72d7b8f0-723f-4bfa-a0d4-fbe5b00f67db" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aed19347-4156-4713-9271-3195703a9bbc",
                column: "ConcurrencyStamp",
                value: "1e1a150f-ffa2-4ba3-959c-1bea08a32b78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aed19347-4156-4713-9272-3195703a9bbd",
                column: "ConcurrencyStamp",
                value: "ff623185-fd61-4c01-a62b-ce5068900bf7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aed19347-4156-4713-9271-9115703a9bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f182b5a4-aae3-45ae-b569-f3b652bc1b63", "AQAAAAEAACcQAAAAEJzX5QEVwfu2WdFLxdwnIHpe8lvZ/XKb94mosT1Os2wpI2Wmbi2Ij1NhX8WMZgbeFw==", "b38e158f-69d1-45b0-b3bc-c2ed68ad2e27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc8f9cbb-3cae-43f6-a04e-0506c7a96120",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff0388c6-004b-42d8-9fdf-d14f4d3241e9", "AQAAAAEAACcQAAAAEDIosgwDokN+ERcaCdGM7m6nSIkuf9veYISpeHOHbTbE/D4LIBN1m8+KPyiJ/IdbIg==", "8aef70dc-2f69-40ec-9abe-354c2dc0ece5" });
        }
    }
}
