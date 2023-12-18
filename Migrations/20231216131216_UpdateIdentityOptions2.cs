using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repair_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIdentityOptions2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6bb3fbe6-0345-4995-97a4-3687552ea9ff", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "40be2647-9a5a-48ed-ae05-a4e430c73b8e", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4a5013b1-27fd-4a1b-8cc0-bffc3aa86890", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8d6fbcc1-b590-4ccf-b35a-5c7d3fade980", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40be2647-9a5a-48ed-ae05-a4e430c73b8e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a5013b1-27fd-4a1b-8cc0-bffc3aa86890");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bb3fbe6-0345-4995-97a4-3687552ea9ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d6fbcc1-b590-4ccf-b35a-5c7d3fade980");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23998714-94eb-44ec-94a8-3690d0f3d77e", null, "Techlead", null },
                    { "2dbed69a-45b3-4ab1-a8d1-f8c10fd16c73", null, "Admin", null },
                    { "5ee23454-cd3f-4438-a8fe-bf159e5dc5c0", null, "Staff", null },
                    { "7f2436f7-1b0e-4138-acf1-6b7ffc4fafb6", null, "Technician", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c848b32e-4efd-49b6-810a-63533a9c4cc3", "AQAAAAIAAYagAAAAEMq5DSnkxUEzXT4KFamMgkekkULjLWAgibL4dGbTaQbPQ5j0U540JPVsvVVU9qU7vg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4373bafa-c89c-4be5-a774-ae9c7015f4e8", "AQAAAAIAAYagAAAAELp2Ub/tDNoKKVoGg9wMX2icU6x7iumoSoj/gtZmhAstNDXqn2c9I8i5jalM75L3Sw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e01aa2a-251f-42dc-bd99-3b3431c7f9b8", "AQAAAAIAAYagAAAAENYm2p1ud2++ucYFiJdQkBejfXGHKng6iTWbhZiDmiEgqElK7+X40FXsTWHV848skg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4aa19f9e-053c-4734-b26f-16b52fccc8d9", "AQAAAAIAAYagAAAAEGqEsvHonXDrJo8I7aqTatauIB7kQg7IyiQTY/82qmcEgQA/okFOUQIuTIyac23oPA==" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 16, 20, 12, 16, 573, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 16, 20, 12, 16, 573, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 16, 20, 12, 16, 573, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2dbed69a-45b3-4ab1-a8d1-f8c10fd16c73", "1" },
                    { "5ee23454-cd3f-4438-a8fe-bf159e5dc5c0", "2" },
                    { "23998714-94eb-44ec-94a8-3690d0f3d77e", "3" },
                    { "7f2436f7-1b0e-4138-acf1-6b7ffc4fafb6", "4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2dbed69a-45b3-4ab1-a8d1-f8c10fd16c73", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ee23454-cd3f-4438-a8fe-bf159e5dc5c0", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "23998714-94eb-44ec-94a8-3690d0f3d77e", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7f2436f7-1b0e-4138-acf1-6b7ffc4fafb6", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23998714-94eb-44ec-94a8-3690d0f3d77e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dbed69a-45b3-4ab1-a8d1-f8c10fd16c73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ee23454-cd3f-4438-a8fe-bf159e5dc5c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f2436f7-1b0e-4138-acf1-6b7ffc4fafb6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40be2647-9a5a-48ed-ae05-a4e430c73b8e", null, "Staff", null },
                    { "4a5013b1-27fd-4a1b-8cc0-bffc3aa86890", null, "Techlead", null },
                    { "6bb3fbe6-0345-4995-97a4-3687552ea9ff", null, "Admin", null },
                    { "8d6fbcc1-b590-4ccf-b35a-5c7d3fade980", null, "Technician", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b1e616c-56e2-4c9d-b2b5-8fd329b926d2", "AQAAAAIAAYagAAAAEMzeT2LHYd7exukpF8n6lHs1IHF+Cdj09VnHag9OOlwljvhMWRQSXH4E5eA5ICFTWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ced7fe75-aab9-438c-9f07-e14de74a2dfb", "AQAAAAIAAYagAAAAEAboIsPoh7q5KB4Fal9LT2KDOFqFwjBwxM7t3ICfnxq+WMpwvlIiek+1nvj2M8z8Aw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8c9ec1f-2479-48e8-80d9-1d258f2ee9b4", "AQAAAAIAAYagAAAAEKfOUmmbIrW7xPxzVlFVtyMpjEvuRzBmB8LeS1tXtq51a13d1NxBkQW11mJgwUWNaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0fb8bc57-b7aa-49dd-a258-3706fca24c1c", "AQAAAAIAAYagAAAAEHpia8HbGnbZYtVsEXdctLtmPlymB8UBfpU62zK96exEsDWJOi8K+mQMYwA6FFIgLg==" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 16, 19, 59, 16, 997, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 16, 19, 59, 16, 997, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 16, 19, 59, 16, 997, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6bb3fbe6-0345-4995-97a4-3687552ea9ff", "1" },
                    { "40be2647-9a5a-48ed-ae05-a4e430c73b8e", "2" },
                    { "4a5013b1-27fd-4a1b-8cc0-bffc3aa86890", "3" },
                    { "8d6fbcc1-b590-4ccf-b35a-5c7d3fade980", "4" }
                });
        }
    }
}
