using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repair_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class Add_User_Props : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c82dbc5-601a-4840-94cf-c0f831509dd8", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d4c3ee1b-4118-4481-a208-c7bd3fe92424", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c82dbc5-601a-4840-94cf-c0f831509dd8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4c3ee1b-4118-4481-a208-c7bd3fe92424");

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "534f6fbd-914c-4e37-82d5-c647cf349f14", null, "Admin", null },
                    { "9eabcdb7-dff6-4eb5-8cbc-62e6581677c3", null, "Staff", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiryTime" },
                values: new object[] { "b9e751c9-c01c-4b46-94b7-5259de695ee6", "NGUYỄN DUY KHÁNH", "AQAAAAIAAYagAAAAEGpzHKrYJUba5KgVgVZ/NNm61c+kim8YH6GB0IWVyK/PVWbarG4yBGCOWHdh4aQZMg==", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "RefreshToken", "RefreshTokenExpiryTime" },
                values: new object[] { "eb0228fc-135d-4770-82d4-0072c5c10bef", "NGUYỄN HOÀNG A", "AQAAAAIAAYagAAAAENl5NnmnhGlHJV4pfMhEYu3BcO1cjsnyoITHAPvR7O/dBky7Jsn4vWF0zSDQq01DCw==", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 12, 18, 13, 47, 41, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 12, 18, 13, 47, 41, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 12, 18, 13, 47, 41, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "534f6fbd-914c-4e37-82d5-c647cf349f14", "1" },
                    { "9eabcdb7-dff6-4eb5-8cbc-62e6581677c3", "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "534f6fbd-914c-4e37-82d5-c647cf349f14", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9eabcdb7-dff6-4eb5-8cbc-62e6581677c3", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "534f6fbd-914c-4e37-82d5-c647cf349f14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9eabcdb7-dff6-4eb5-8cbc-62e6581677c3");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c82dbc5-601a-4840-94cf-c0f831509dd8", null, "Admin", null },
                    { "d4c3ee1b-4118-4481-a208-c7bd3fe92424", null, "Staff", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "99767332-8982-4988-8ea8-608c57253825", "NGUYEN DUY KHANH", "AQAAAAIAAYagAAAAEKgwauJa7I4bSGJ2OZDXDJBHPtEfYQf8nqWSh2aBdqD9E+E2W1q0BrFffpIA4tNdnA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "a74ec75c-c3c6-444d-9ecb-b0a1455cdcc4", "NGUYEN HOANG A", "AQAAAAIAAYagAAAAEIqpXH0KFrqlUkm3YWbGSP4abWNnmhqmSlheTOEOUZ89br9f5Sy3WYU0dzu44iEUzQ==" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 21, 17, 31, 409, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 21, 17, 31, 409, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 21, 17, 31, 409, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4c82dbc5-601a-4840-94cf-c0f831509dd8", "1" },
                    { "d4c3ee1b-4118-4481-a208-c7bd3fe92424", "2" }
                });
        }
    }
}
