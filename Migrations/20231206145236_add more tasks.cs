using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repair_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class addmoretasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57e5fe0c-273b-4920-a9c7-67a5acf08c40", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e0202692-4be9-4182-a2fd-3034055d0447", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4d30968-d935-4128-985c-83642a5cc959", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4035ce5c-4731-4fb2-af49-ff433db651aa", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4035ce5c-4731-4fb2-af49-ff433db651aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57e5fe0c-273b-4920-a9c7-67a5acf08c40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0202692-4be9-4182-a2fd-3034055d0447");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4d30968-d935-4128-985c-83642a5cc959");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "4035ce5c-4731-4fb2-af49-ff433db651aa", null, "Technician", null },
                    { "57e5fe0c-273b-4920-a9c7-67a5acf08c40", null, "Admin", null },
                    { "e0202692-4be9-4182-a2fd-3034055d0447", null, "Staff", null },
                    { "f4d30968-d935-4128-985c-83642a5cc959", null, "Techlead", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b0578801-243c-4b7b-837f-aaa065ee54af", "AQAAAAIAAYagAAAAEK3wP8iKQR+xlAIaXoVb+M83Tv/fkUoaNGdzM9HDcUB3chCrKsiwho5SGik5nC0jfg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "415dd5b1-2c3a-4f39-acd7-698ad9fb760f", "AQAAAAIAAYagAAAAEC4oWLf2CdkOOKOTz1+GyOcKyDTD4h6AJSkGbZL461qeNcRb+AgVsbUFmmAP18L1ug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c608353-aaa0-4281-957a-e8b23488da59", "AQAAAAIAAYagAAAAEJCp+k7Bf/OinBjYS70wyE+HKTr3VqozTQQAOhPxLTYl5mSJkSJpLF1anOGN3ymEDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "495163f0-4ed8-475a-812e-21a61ba13e13", "AQAAAAIAAYagAAAAEGx/TEY4OHLe7NKp/Z4giTkZ2CLAjgzLUUYVVpIf33DnbaFzL+VvjlaIo3qi4fyLeA==" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 3, 17, 25, 16, 620, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 3, 17, 25, 16, 620, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 3, 17, 25, 16, 620, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "57e5fe0c-273b-4920-a9c7-67a5acf08c40", "1" },
                    { "e0202692-4be9-4182-a2fd-3034055d0447", "2" },
                    { "f4d30968-d935-4128-985c-83642a5cc959", "3" },
                    { "4035ce5c-4731-4fb2-af49-ff433db651aa", "4" }
                });
        }
    }
}
