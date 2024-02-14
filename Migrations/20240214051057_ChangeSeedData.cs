using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repair_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dd1bcdad-35e4-486e-ad63-19aca5e80e35", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "009bcfb0-bcab-40c9-a759-bbb55562519e", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a7d13cf3-9de4-4736-8bf2-d9fafcc1a232", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a7d13cf3-9de4-4736-8bf2-d9fafcc1a232", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c896a667-3ea4-4b98-af9d-2545ea4b188c", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c896a667-3ea4-4b98-af9d-2545ea4b188c", "6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "009bcfb0-bcab-40c9-a759-bbb55562519e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7d13cf3-9de4-4736-8bf2-d9fafcc1a232");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c896a667-3ea4-4b98-af9d-2545ea4b188c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd1bcdad-35e4-486e-ad63-19aca5e80e35");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a61fe99-5f44-41ad-9971-9eb02f6c6967", null, "Admin", "ADMIN" },
                    { "2e2bb7b8-ee8c-49b9-b769-47ad74670192", null, "Receiver", "RECEIVER" },
                    { "89465bea-717b-4537-89b9-cf1ba93b003d", null, "Technician", "TECHNICIAN" },
                    { "cdd4acd7-5c3d-4a54-8381-4c687fc36fd3", null, "Creator", "CREATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5cc18446-5ba0-44a3-84fb-bdbe6f345ea6", "AQAAAAIAAYagAAAAEMjUkUrDPlI+sxE01LN/qzeT2KCG5nUfnKsbnJgvRQIjTJ7WXWLKQVvhgIQAc9wDsw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61d9a32b-8e81-43a3-a2ad-0e1303a7a687", "AQAAAAIAAYagAAAAED1ey3LlGizdzVWqRKZfOshOVIVvtHpwICHj9nZmrZyClFONONvviTX+sMgFCj2UZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aed1e4c4-e7d6-4750-bfe9-f860f0156e3a", "AQAAAAIAAYagAAAAEAPhgIMNoehvUXNtuawdzjbhS1PN/MGxL6sbEpR9ruIl2dYD4KPP/i3UlZTsPFQVJw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fdef75c5-6577-4808-96a2-b7c566e61ca5", "AQAAAAIAAYagAAAAEJB/g8E+Q+ncz1xJhSPqrpMv7K9xyTG5yb5JLnrHpaz19Mie3leauMSb78Fveasttw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "964d7b92-917b-4900-8c90-30347a380cbd", "AQAAAAIAAYagAAAAELgyNEa5JVlbqGZAsK7pTC/Jm9dDzlmFfwZ6y6PrljVQHovxiJQR/lqVclYKSaDB7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b83d51ac-ced8-4e8c-9fdc-ce4af3365727", "AQAAAAIAAYagAAAAENaiUNtFI/XT7w/DIQxc54dkVRRl3XGom0ipDxwIZbZ6/349RXY4ZLzn8UAKQcPc/A==" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 14, 12, 10, 57, 468, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 14, 12, 10, 57, 468, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 14, 12, 10, 57, 468, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "PurchasedProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "WarrantyPeriod",
                value: new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PurchasedProducts",
                keyColumn: "Id",
                keyValue: 6,
                column: "WarrantyPeriod",
                value: new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PurchasedProducts",
                keyColumn: "Id",
                keyValue: 7,
                column: "WarrantyPeriod",
                value: new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PurchasedProducts",
                keyColumn: "Id",
                keyValue: 8,
                column: "WarrantyPeriod",
                value: new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0a61fe99-5f44-41ad-9971-9eb02f6c6967", "1" },
                    { "cdd4acd7-5c3d-4a54-8381-4c687fc36fd3", "2" },
                    { "2e2bb7b8-ee8c-49b9-b769-47ad74670192", "3" },
                    { "2e2bb7b8-ee8c-49b9-b769-47ad74670192", "4" },
                    { "89465bea-717b-4537-89b9-cf1ba93b003d", "5" },
                    { "89465bea-717b-4537-89b9-cf1ba93b003d", "6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0a61fe99-5f44-41ad-9971-9eb02f6c6967", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cdd4acd7-5c3d-4a54-8381-4c687fc36fd3", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e2bb7b8-ee8c-49b9-b769-47ad74670192", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e2bb7b8-ee8c-49b9-b769-47ad74670192", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "89465bea-717b-4537-89b9-cf1ba93b003d", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "89465bea-717b-4537-89b9-cf1ba93b003d", "6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a61fe99-5f44-41ad-9971-9eb02f6c6967");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e2bb7b8-ee8c-49b9-b769-47ad74670192");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89465bea-717b-4537-89b9-cf1ba93b003d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdd4acd7-5c3d-4a54-8381-4c687fc36fd3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "009bcfb0-bcab-40c9-a759-bbb55562519e", null, "Creator", "CREATOR" },
                    { "a7d13cf3-9de4-4736-8bf2-d9fafcc1a232", null, "Receiver", "RECEIVER" },
                    { "c896a667-3ea4-4b98-af9d-2545ea4b188c", null, "Technician", "TECHNICIAN" },
                    { "dd1bcdad-35e4-486e-ad63-19aca5e80e35", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06030b66-424c-4f7d-9e25-a17a4a17dcc9", "AQAAAAIAAYagAAAAEGIAyXs0SMwJnHGrmygTmK8t5MQhpdilfrL7HFsc0A072ZFavsc1hGxXtVJLyHo25Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0554bdec-abaa-48a2-86b1-4c633d448f45", "AQAAAAIAAYagAAAAEONyZfgmtTLW4Evv19Be2SNzMh3uh7cqQDycwZE4wSIdPg5PeSRTOOmOIxHOsro3DA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92fd44cb-4f04-495e-b2e9-dc4b5fb2d707", "AQAAAAIAAYagAAAAECPnEH0pTCpayp/DElveZfTQ/kvgIMjEIT65yTJNJrVcyMzMvityB9E3GVpHJCV7Ow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e75d5485-4d6e-45f3-a491-6b7032fe2b4c", "AQAAAAIAAYagAAAAEIGi/y76/1CTr3z5JHZg4+wcO0Vgn4ds1Z8kS6d7czrhctOvgFxjGzBuC17P+Mv3Dg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e359824-3a2e-4e7c-b220-1a547e169a5b", "AQAAAAIAAYagAAAAEL8q2Mz2WlbnmetAaZaDluAiinejGI+OXemtgDx1S+67L26bXjVQ5QJ8dIf8jFEKPA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a590615e-3d85-4da5-94f8-61c530783b96", "AQAAAAIAAYagAAAAEIebcVVn1ErGJ+qW6syhmswMW7bU9fvSaGbfc1j7hAOCX/xrTdIzqmXONavHlZT++Q==" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 13, 16, 41, 4, 850, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 13, 16, 41, 4, 850, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 2, 13, 16, 41, 4, 850, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "PurchasedProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "WarrantyPeriod",
                value: new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PurchasedProducts",
                keyColumn: "Id",
                keyValue: 6,
                column: "WarrantyPeriod",
                value: new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PurchasedProducts",
                keyColumn: "Id",
                keyValue: 7,
                column: "WarrantyPeriod",
                value: new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PurchasedProducts",
                keyColumn: "Id",
                keyValue: 8,
                column: "WarrantyPeriod",
                value: new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dd1bcdad-35e4-486e-ad63-19aca5e80e35", "1" },
                    { "009bcfb0-bcab-40c9-a759-bbb55562519e", "2" },
                    { "a7d13cf3-9de4-4736-8bf2-d9fafcc1a232", "3" },
                    { "a7d13cf3-9de4-4736-8bf2-d9fafcc1a232", "4" },
                    { "c896a667-3ea4-4b98-af9d-2545ea4b188c", "5" },
                    { "c896a667-3ea4-4b98-af9d-2545ea4b188c", "6" }
                });
        }
    }
}
