using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repair_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class addwarranty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "WarrantyPolicies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarrantyPolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WarrantyPolicies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WarrantyPolicyTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarrantyPolicyId = table.Column<int>(type: "int", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarrantyPolicyTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WarrantyPolicyTasks_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WarrantyPolicyTasks_WarrantyPolicies_WarrantyPolicyId",
                        column: x => x.WarrantyPolicyId,
                        principalTable: "WarrantyPolicies",
                        principalColumn: "Id");
                });

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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Card màn hình");

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
                table: "Tasks",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 6, "Sửa chữa phần cứng", 0.0 });

            migrationBuilder.InsertData(
                table: "WarrantyPolicies",
                columns: new[] { "Id", "CategoryId", "Description" },
                values: new object[,]
                {
                    { 1, 1, "Chính sách bảo hành của Màn hình" },
                    { 2, 2, "Chính sách bảo hành của Nguồn máy tính" },
                    { 3, 3, "Chính sách bảo hành của Mainboard" },
                    { 4, 4, "Chính sách bảo hành của Chuột" },
                    { 5, 5, "Chính sách bảo hành của Bàn phím" },
                    { 6, 6, "Chính sách bảo hành của Thiết bị lưu trữ, bộ nhớ" },
                    { 7, 7, "Chính sách bảo hành của Tai nghe" },
                    { 8, 8, "Chính sách bảo hành của CPU" },
                    { 9, 9, "Chính sách bảo hành của VGA" },
                    { 10, 10, "Chính sách bảo hành của Tản nhiệt" },
                    { 11, 11, "Chính sách bảo hành của Card màn hình" },
                    { 12, 12, "Chính sách bảo hành của Webcam" },
                    { 13, 13, "Chính sách bảo hành của PC" },
                    { 14, 14, "Chính sách bảo hành của Thiết bị ngoại vi" }
                });

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

            migrationBuilder.InsertData(
                table: "WarrantyPolicyTasks",
                columns: new[] { "Id", "TaskId", "WarrantyPolicyId" },
                values: new object[,]
                {
                    { 1, 4, 1 },
                    { 2, 6, 1 },
                    { 3, 4, 2 },
                    { 4, 6, 2 },
                    { 5, 4, 3 },
                    { 6, 6, 3 },
                    { 7, 4, 4 },
                    { 8, 5, 4 },
                    { 9, 6, 4 },
                    { 10, 4, 5 },
                    { 11, 5, 5 },
                    { 12, 6, 5 },
                    { 13, 4, 6 },
                    { 14, 5, 6 },
                    { 15, 4, 7 },
                    { 16, 5, 7 },
                    { 17, 5, 8 },
                    { 18, 4, 9 },
                    { 19, 5, 9 },
                    { 20, 4, 10 },
                    { 21, 6, 10 },
                    { 22, 4, 11 },
                    { 23, 5, 11 },
                    { 24, 6, 11 },
                    { 25, 5, 12 },
                    { 26, 6, 12 },
                    { 27, 4, 13 },
                    { 28, 6, 13 },
                    { 29, 4, 14 },
                    { 30, 5, 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WarrantyPolicies_CategoryId",
                table: "WarrantyPolicies",
                column: "CategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WarrantyPolicyTasks_TaskId",
                table: "WarrantyPolicyTasks",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_WarrantyPolicyTasks_WarrantyPolicyId",
                table: "WarrantyPolicyTasks",
                column: "WarrantyPolicyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WarrantyPolicyTasks");

            migrationBuilder.DropTable(
                name: "WarrantyPolicies");

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
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6);

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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Ergonomic");

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
    }
}
