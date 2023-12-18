using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repair_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class changepasswordsetting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "286834b0-bb90-4b49-920f-429a704f443f", null, "Technician", "TECHNICIAN" },
                    { "7525dcbb-2525-4a70-9fbc-b20297997287", null, "Admin", "ADMIN" },
                    { "ea408df1-96f5-4af8-a705-b804b1f54e98", null, "Staff", "STAFF" },
                    { "f0ae4d4e-374b-4eb2-b9f2-79f0cf62e7b6", null, "Techlead", "TECHLEAD" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68921891-a14f-4774-a875-339e136dbeda", "AQAAAAIAAYagAAAAEH6mojtFf5WB/EHaNpQu9ftt6msZ/ety+K/sapzNuErMJhJJsDBwDwGW+mbGG7K96Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac2b6c38-c89a-494e-91d0-973f79499938", "AQAAAAIAAYagAAAAEHotuAFN+zZHSDuECQzv72M65jp4UycgtpV3gcut7XRNqjXlV0jE++4PWSF6LYIZZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d79f8559-7730-403b-b17c-155a8421dfff", "AQAAAAIAAYagAAAAEDLEn+kokrFA7jpej1MwAI8tyJERVby+MPRiPpvYYs7xcMgRV9ULRWjMYPR4k36PLg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac06fe36-4d82-4f52-b8cb-912839043c1b", "AQAAAAIAAYagAAAAEMlSBomULsJ9XstfLXWhgE+WluSVHyHAD/bGeeeFrpMRPa6rePXlSjNVJwfvUBczgg==" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 16, 22, 11, 1, 249, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 16, 22, 11, 1, 249, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 16, 22, 11, 1, 249, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7525dcbb-2525-4a70-9fbc-b20297997287", "1" },
                    { "ea408df1-96f5-4af8-a705-b804b1f54e98", "2" },
                    { "f0ae4d4e-374b-4eb2-b9f2-79f0cf62e7b6", "3" },
                    { "286834b0-bb90-4b49-920f-429a704f443f", "4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7525dcbb-2525-4a70-9fbc-b20297997287", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ea408df1-96f5-4af8-a705-b804b1f54e98", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f0ae4d4e-374b-4eb2-b9f2-79f0cf62e7b6", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "286834b0-bb90-4b49-920f-429a704f443f", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "286834b0-bb90-4b49-920f-429a704f443f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7525dcbb-2525-4a70-9fbc-b20297997287");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea408df1-96f5-4af8-a705-b804b1f54e98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0ae4d4e-374b-4eb2-b9f2-79f0cf62e7b6");

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
    }
}
