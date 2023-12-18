using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repair_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class addmoretasks2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "55307ace-2631-408d-b8ab-fb14859dc5c4", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c70336ef-ab3a-4866-a9e8-5f3e727766f9", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2098a330-2087-4924-984b-c2bdcf949d3d", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c191e0a6-c0e5-4c7e-822d-c37f34ab7692", "4" });

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2098a330-2087-4924-984b-c2bdcf949d3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55307ace-2631-408d-b8ab-fb14859dc5c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c191e0a6-c0e5-4c7e-822d-c37f34ab7692");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c70336ef-ab3a-4866-a9e8-5f3e727766f9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2458f121-4cc4-4892-8fd3-8135adb29345", null, "Admin", null },
                    { "4a0502af-3c6b-4a2e-9b7b-963378e67666", null, "Staff", null },
                    { "8cfbaaf8-30e0-464f-8597-92c32e7fe7d2", null, "Techlead", null },
                    { "cbe2bb35-2906-4c4d-88d0-59fd6a628548", null, "Technician", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "872be684-ce70-424b-8bb4-6ac81483c3d3", "AQAAAAIAAYagAAAAEFpTstCaf51epjv5Ml++Ccz8c80njmqQhekxu+x2f1MZxl8Ry+E3YEz0Jn4PV6qrCQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16bdd2ac-0927-4d18-9f17-ea2c921c1bee", "AQAAAAIAAYagAAAAEP79cPnTif5mb6IX/fUgTEIXbi7JPyUXzGej6gRxuHXvlo5CTZN1dGE13Jf6lMGcWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "644cd1e0-1f84-43b1-9dc6-3408455a33fc", "AQAAAAIAAYagAAAAENiaYUUYpffDSlQy0yHK8phQP3D58xVnoAIHmb+gBX3p2iw48Ox9mrEA54vAs5tBWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff6e3da8-52d1-4931-ac1a-54afed159e97", "AQAAAAIAAYagAAAAEO/qC2F7lmiC5iVW5rNsuEBj4tuUl/prahSXwHJIfLImLm4+eQV7b8yCGcbi+T02ug==" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 6, 21, 55, 4, 823, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 6, 21, 55, 4, 823, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 6, 21, 55, 4, 823, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Vệ sinh sản phẩm");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Cài đặt phần mềm", 50000.0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Sửa chữa phần mềm", 100000.0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Thay thế linh kiện");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Đổi mới", 0.0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2458f121-4cc4-4892-8fd3-8135adb29345", "1" },
                    { "4a0502af-3c6b-4a2e-9b7b-963378e67666", "2" },
                    { "8cfbaaf8-30e0-464f-8597-92c32e7fe7d2", "3" },
                    { "cbe2bb35-2906-4c4d-88d0-59fd6a628548", "4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2458f121-4cc4-4892-8fd3-8135adb29345", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4a0502af-3c6b-4a2e-9b7b-963378e67666", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8cfbaaf8-30e0-464f-8597-92c32e7fe7d2", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbe2bb35-2906-4c4d-88d0-59fd6a628548", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2458f121-4cc4-4892-8fd3-8135adb29345");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a0502af-3c6b-4a2e-9b7b-963378e67666");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cfbaaf8-30e0-464f-8597-92c32e7fe7d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbe2bb35-2906-4c4d-88d0-59fd6a628548");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2098a330-2087-4924-984b-c2bdcf949d3d", null, "Techlead", null },
                    { "55307ace-2631-408d-b8ab-fb14859dc5c4", null, "Admin", null },
                    { "c191e0a6-c0e5-4c7e-822d-c37f34ab7692", null, "Technician", null },
                    { "c70336ef-ab3a-4866-a9e8-5f3e727766f9", null, "Staff", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b3245a0d-6a80-4927-bed8-d6bc7f0493a8", "AQAAAAIAAYagAAAAEJr1Q2ENu1RgYHKO8ekyNGnLtDwsQt10t0eZKGrOSaQHYK2ymwYVS0Wq3MbsyEq0hw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ac7076b-3b47-4a32-8d3c-3246307e975d", "AQAAAAIAAYagAAAAEFglsUDuWvFREkG6/aTeKmqMJZUlAk0gQI20ha/lTBhQpAYNOo9SBp6JSYVHAi3wcQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb6d3ca4-7a0a-40b1-a86f-77e677c40e08", "AQAAAAIAAYagAAAAEE2r5U1K0ixSdahU4IkZ1tkKZm45gk9elbPgyatn5jZPvIxEMPw2MAzBFKsfiKLIew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d48d601-1a1d-4c1c-affe-ed0dd7859e98", "AQAAAAIAAYagAAAAEBNvcK9FwtGnuIPxrdwMgotPXShm3zUKFnwSp+Ud+meURQg/YjAJm5tXUezVC+AcGQ==" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 6, 21, 52, 35, 750, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 6, 21, 52, 35, 750, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 6, 21, 52, 35, 750, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Vệ sinh máy tính");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Cài lại win", 200000.0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Cài đặt phần mềm", 50000.0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Sửa chữa phần mềm");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Bảo dưỡng định kỳ", 100000.0 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 6, "Bảo dưỡng định kỳ", 0.0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "55307ace-2631-408d-b8ab-fb14859dc5c4", "1" },
                    { "c70336ef-ab3a-4866-a9e8-5f3e727766f9", "2" },
                    { "2098a330-2087-4924-984b-c2bdcf949d3d", "3" },
                    { "c191e0a6-c0e5-4c7e-822d-c37f34ab7692", "4" }
                });
        }
    }
}
