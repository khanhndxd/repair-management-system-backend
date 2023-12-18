using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repair_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class Changerolename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "24b17cc8-44a8-4d55-9a94-7ba39fedc768", null, "Creator", "CREATOR" },
                    { "28ed9c30-8f1d-40ae-8ffe-675b323153f2", null, "Receiver", "RECEIVER" },
                    { "6f678273-e39a-40f6-924b-2e2d1ba2a392", null, "Admin", "ADMIN" },
                    { "d2952c29-c0f2-4837-8409-c48e574a1954", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91236f40-4910-4640-a486-e898144bfd1c", "AQAAAAIAAYagAAAAED1gLNLbQ31S7EvHmBEWkcvF5u8/yIfsea0GQ26Xw3fDkhHmMi1SSseP2+xuvvs3GQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "0fd61d17-8ee9-487a-b8bd-77a8f8a65c73", "creator1@creator.com", "CREATOR1@CREATOR.COM", "AQAAAAIAAYagAAAAEIpdiHiBzcRtwcUbbVy8ZZl1nDmIF6PedPKYVr3pqShHdQ3LkU2lwwhqoSVSVOttng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "974d8667-65a7-468c-ac4e-193ec5a86e5f", "receiver1@receiver.com", "RECEIVER1@RECEIVER.COM", "AQAAAAIAAYagAAAAENKK/sYumtAJThHCDZRUtUb1tzrTObh7v0vklpLLo1eymPeVB8LKahf1LI0SEkNPdg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e876c55-ccb8-41f3-b624-3c394afc347f", "AQAAAAIAAYagAAAAEL8VHvXT6i8AYCrf1MeEb9e/gm/5hg0y07cCJbbEamoqR/WlSUh0ZeuENF0SqjGz4Q==" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 17, 11, 35, 29, 940, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 17, 11, 35, 29, 940, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 17, 11, 35, 29, 940, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6f678273-e39a-40f6-924b-2e2d1ba2a392", "1" },
                    { "24b17cc8-44a8-4d55-9a94-7ba39fedc768", "2" },
                    { "28ed9c30-8f1d-40ae-8ffe-675b323153f2", "3" },
                    { "d2952c29-c0f2-4837-8409-c48e574a1954", "4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f678273-e39a-40f6-924b-2e2d1ba2a392", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "24b17cc8-44a8-4d55-9a94-7ba39fedc768", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28ed9c30-8f1d-40ae-8ffe-675b323153f2", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d2952c29-c0f2-4837-8409-c48e574a1954", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24b17cc8-44a8-4d55-9a94-7ba39fedc768");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28ed9c30-8f1d-40ae-8ffe-675b323153f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f678273-e39a-40f6-924b-2e2d1ba2a392");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2952c29-c0f2-4837-8409-c48e574a1954");

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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "ac2b6c38-c89a-494e-91d0-973f79499938", "staff1@staff.com", "STAFF1@STAFF.COM", "AQAAAAIAAYagAAAAEHotuAFN+zZHSDuECQzv72M65jp4UycgtpV3gcut7XRNqjXlV0jE++4PWSF6LYIZZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "d79f8559-7730-403b-b17c-155a8421dfff", "lead1@lead.com", "LEAD1@LEAD.COM", "AQAAAAIAAYagAAAAEDLEn+kokrFA7jpej1MwAI8tyJERVby+MPRiPpvYYs7xcMgRV9ULRWjMYPR4k36PLg==" });

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
    }
}
