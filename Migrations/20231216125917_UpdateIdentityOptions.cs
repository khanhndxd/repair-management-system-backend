using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repair_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIdentityOptions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0bc99998-62b9-49f7-bd7e-7017d44f8b1a", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1aa18702-5561-400c-a896-9a6d5aa31cb7", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0f6054c6-17c2-4157-b92f-2eefad68f2ca", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "019458b9-c4aa-42e6-a2d3-33b6b80dcc79", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "019458b9-c4aa-42e6-a2d3-33b6b80dcc79");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0bc99998-62b9-49f7-bd7e-7017d44f8b1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f6054c6-17c2-4157-b92f-2eefad68f2ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1aa18702-5561-400c-a896-9a6d5aa31cb7");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "019458b9-c4aa-42e6-a2d3-33b6b80dcc79", null, "Technician", null },
                    { "0bc99998-62b9-49f7-bd7e-7017d44f8b1a", null, "Admin", null },
                    { "0f6054c6-17c2-4157-b92f-2eefad68f2ca", null, "Techlead", null },
                    { "1aa18702-5561-400c-a896-9a6d5aa31cb7", null, "Staff", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1fa063a7-1fa5-4fe1-ae4e-857cfe5aed48", "AQAAAAIAAYagAAAAECcuOs3H2Dm9r6ulvZwASbTOO7nMYKgeagcWTGij3VTERA6O+1fVJP9GHUTNWeZpZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23c9bcdc-c514-45d2-ba80-dd3395928def", "AQAAAAIAAYagAAAAEJIXbU4FKqZTVXK9pNe4/qR4Bm9dqJYVVzWIC7G79ZwzaAj6xXhQYdPyzYc+q1uDdQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5093c23c-84c5-4cdb-a983-eab5bf6517f6", "AQAAAAIAAYagAAAAEEij1o7id/il1wVVoNve1eymG1BsqaDebTFMxjN0o1yWcqUhVw5z4L6avMtpoEy5TA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bcc020f7-b6d9-4561-8fd1-8fc4510b22a2", "AQAAAAIAAYagAAAAEJHhEZtXNfoU8Gd3Xtdk+bxJggerGyd3laBgCeUDyVGPy2T1JdDddO6gpPkB7I6zHQ==" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 13, 15, 54, 37, 253, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 13, 15, 54, 37, 253, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 13, 15, 54, 37, 253, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0bc99998-62b9-49f7-bd7e-7017d44f8b1a", "1" },
                    { "1aa18702-5561-400c-a896-9a6d5aa31cb7", "2" },
                    { "0f6054c6-17c2-4157-b92f-2eefad68f2ca", "3" },
                    { "019458b9-c4aa-42e6-a2d3-33b6b80dcc79", "4" }
                });
        }
    }
}
