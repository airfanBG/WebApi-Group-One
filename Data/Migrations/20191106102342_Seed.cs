using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AccountNumber", "CreatedAt", "DeletedAt", "ModifiedAt", "PersonId" },
                values: new object[] { 1, "1234", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 3 });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DepartmentName", "ModifiedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 11, 6, 12, 23, 42, 136, DateTimeKind.Local).AddTicks(7792), null, "Sells", null },
                    { 2, new DateTime(2019, 11, 6, 12, 23, 42, 136, DateTimeKind.Local).AddTicks(8342), null, "Finance", null },
                    { 3, new DateTime(2019, 11, 6, 12, 23, 42, 136, DateTimeKind.Local).AddTicks(8364), null, "IT", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CurrentQuantity", "DeletedAt", "Description", "ModifiedAt", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 11, 6, 12, 23, 42, 136, DateTimeKind.Local).AddTicks(3014), 100, null, "Daily", null, "T-shirt", 10m },
                    { 2, new DateTime(2019, 11, 6, 12, 23, 42, 136, DateTimeKind.Local).AddTicks(5518), 50, null, "Daily", null, "Jacket", 150m },
                    { 3, new DateTime(2019, 11, 6, 12, 23, 42, 136, DateTimeKind.Local).AddTicks(5570), 200, null, "Daily", null, "Shoes", 125m },
                    { 4, new DateTime(2019, 11, 6, 12, 23, 42, 136, DateTimeKind.Local).AddTicks(5576), 1000, null, "Daily", null, "Socks", 2m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "RoleName" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 11, 6, 12, 23, 42, 137, DateTimeKind.Local).AddTicks(4271), null, null, "Admin" },
                    { 2, new DateTime(2019, 11, 6, 12, 23, 42, 137, DateTimeKind.Local).AddTicks(4794), null, null, "User" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "LastName", "ModifiedAt", "Password" },
                values: new object[] { 4, new DateTime(2019, 11, 6, 12, 23, 42, 130, DateTimeKind.Local).AddTicks(5457), null, "dasda@das.vf", "one", "one", null, "1234" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AccountNumber", "CreatedAt", "DeletedAt", "ModifiedAt", "PersonId" },
                values: new object[] { 2, "1234", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 4 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BankAccount", "CreatedAt", "DeletedAt", "DepartmentId", "EmployeeNumber", "ModifiedAt", "PersonId", "Telephone" },
                values: new object[] { 1, 100000, new DateTime(2019, 11, 6, 12, 23, 42, 137, DateTimeKind.Local).AddTicks(2728), null, 3, "EA0011", null, 2, "1231231" });

            migrationBuilder.InsertData(
                table: "SalesOrders",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "DateOfSale", "DeletedAt", "ModifiedAt", "Note", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(885), null, null, "", 1, 5 },
                    { 5, new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3694), null, null, "", 1, 10 },
                    { 2, new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3485), 1, new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3427), null, null, "", 2, 15 },
                    { 7, new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3702), null, null, "", 2, 1 },
                    { 4, new DateTime(2019, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3689), null, null, "", 4, 8 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 11, 6, 12, 23, 42, 137, DateTimeKind.Local).AddTicks(5531), null, null, 1, 2 },
                    { 2, new DateTime(2019, 11, 6, 12, 23, 42, 137, DateTimeKind.Local).AddTicks(6508), null, null, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "SalesOrders",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "DateOfSale", "DeletedAt", "ModifiedAt", "Note", "ProductId", "Quantity" },
                values: new object[] { 3, new DateTime(2019, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3490), null, null, "", 3, 3 });

            migrationBuilder.InsertData(
                table: "SalesOrders",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "DateOfSale", "DeletedAt", "ModifiedAt", "Note", "ProductId", "Quantity" },
                values: new object[] { 6, new DateTime(2019, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3698), null, null, "", 4, 7 });

            migrationBuilder.InsertData(
                table: "SalesOrders",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "DateOfSale", "DeletedAt", "ModifiedAt", "Note", "ProductId", "Quantity" },
                values: new object[] { 8, new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3709), 2, new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3706), null, null, "", 2, 11 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
