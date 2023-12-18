using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repair_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class updateroletableindb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "518f378e-871d-4d75-bc5b-da01ad4b19b0", null, "Technician", "TECHNICIAN" },
                    { "7e674fc4-648b-4353-81c6-0e2e8e96a63a", null, "Techlead", "TECHLEAD" },
                    { "e93767a2-cd85-4b65-9120-7a75a0346fc6", null, "Admin", "ADMIN" },
                    { "f5088d42-66fe-4bca-ab83-e0e90c959c2d", null, "Staff", "STAFF" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a7672e7-a96d-496d-b086-4eb0685d1ea6", "AQAAAAIAAYagAAAAECB9J3hOh2E8kSyoOJ6Fx/vwPIpKo31JCJ4bHPJgBEVD2B+jZNSEV4iHiVc9dPQeVg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d36e00b-b331-4e06-a26f-b5d3f1fffe61", "AQAAAAIAAYagAAAAEAK1GCvpmDjrmbUaFsP0b3ia7b8nOTvoIjkJNsCpZwEbX3Lvn4aIcXNXIbFSTO2EVw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c20faa63-5880-40fc-bfc1-1a02e26bbe44", "AQAAAAIAAYagAAAAELzypfOJM3UygslnntAcd2kD57gUG2QQrMH5EZgFminEOZtmIfnV6wkZgPwKYJ+kQQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d6d92e7-9c49-433b-bf54-b16c9370f9f7", "AQAAAAIAAYagAAAAENyuHHVLbCnXeW3C4m2OKcJesDqWdJ88THfob4wyAg2CGyuAGJ/5G53+puIgcO1r9A==" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 16, 21, 54, 38, 516, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 16, 21, 54, 38, 516, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 16, 21, 54, 38, 516, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e93767a2-cd85-4b65-9120-7a75a0346fc6", "1" },
                    { "f5088d42-66fe-4bca-ab83-e0e90c959c2d", "2" },
                    { "7e674fc4-648b-4353-81c6-0e2e8e96a63a", "3" },
                    { "518f378e-871d-4d75-bc5b-da01ad4b19b0", "4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e93767a2-cd85-4b65-9120-7a75a0346fc6", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f5088d42-66fe-4bca-ab83-e0e90c959c2d", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7e674fc4-648b-4353-81c6-0e2e8e96a63a", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "518f378e-871d-4d75-bc5b-da01ad4b19b0", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "518f378e-871d-4d75-bc5b-da01ad4b19b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e674fc4-648b-4353-81c6-0e2e8e96a63a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e93767a2-cd85-4b65-9120-7a75a0346fc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5088d42-66fe-4bca-ab83-e0e90c959c2d");

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
    }
}
