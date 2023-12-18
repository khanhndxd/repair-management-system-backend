using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repair_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIdentityOptions3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "028b6580-2fc0-4054-a0b5-8672dbe4c28d", null, "Techlead", null },
                    { "bbbbc3e8-864a-450a-ba15-8410bca9efe4", null, "Admin", null },
                    { "d0799e05-d9fe-4746-a77a-e999f0509b6f", null, "Technician", null },
                    { "ef347cdb-cbc2-4689-84c7-09602de39d52", null, "Staff", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99533c42-cbd9-41bd-9e3b-982c0d3aa405", "AQAAAAIAAYagAAAAECSVjCXGHFX7BjhmjdfSo1Y01uNw3yQAq08EJ14LL5cOPPXW8Pzh1x72lCyakPpLOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d933b76-d7e6-4eb2-aa46-1f36ce238412", "AQAAAAIAAYagAAAAEPxDXkm3s2JnxbphYraLIw7NvAb7PEoe7QzOLxFPPm/gPUrv9Lz+Qk3LeoLhTa0/OQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9804bb54-0231-4cdc-8c9e-2f1d1e6f8f5b", "AQAAAAIAAYagAAAAEG5pxzxxZen2o8Fm82Ik5OcAZ8poFw9ZTV8InywcMJgjbaOpWp3KeY5ALZYyzEfsyA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b790c3d0-7d85-4f00-917c-7512fa6cb4fd", "AQAAAAIAAYagAAAAEC60WtqDnfRTSJzGWvnUzY7oC9fvFudzObjf8ABN2TMWaE+vqOFxtb4xVLNyjOU+Gw==" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 16, 20, 19, 3, 648, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 16, 20, 19, 3, 648, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 16, 20, 19, 3, 648, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bbbbc3e8-864a-450a-ba15-8410bca9efe4", "1" },
                    { "ef347cdb-cbc2-4689-84c7-09602de39d52", "2" },
                    { "028b6580-2fc0-4054-a0b5-8672dbe4c28d", "3" },
                    { "d0799e05-d9fe-4746-a77a-e999f0509b6f", "4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bbbbc3e8-864a-450a-ba15-8410bca9efe4", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef347cdb-cbc2-4689-84c7-09602de39d52", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "028b6580-2fc0-4054-a0b5-8672dbe4c28d", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0799e05-d9fe-4746-a77a-e999f0509b6f", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "028b6580-2fc0-4054-a0b5-8672dbe4c28d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbbbc3e8-864a-450a-ba15-8410bca9efe4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0799e05-d9fe-4746-a77a-e999f0509b6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef347cdb-cbc2-4689-84c7-09602de39d52");

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
    }
}
