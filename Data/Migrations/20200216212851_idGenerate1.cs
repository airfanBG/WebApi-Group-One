using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class idGenerate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "41ee5855-1d8b-4b8c-bfad-0a97d3a67738", new DateTime(2020, 2, 16, 23, 28, 50, 328, DateTimeKind.Local).AddTicks(9839), "2aa828a0-0fe4-434f-b3e3-ddd7dd8bfced" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "d642a01c-e048-4d17-872b-808ba929992b", new DateTime(2020, 2, 16, 23, 28, 50, 332, DateTimeKind.Local).AddTicks(6859), "acbbd39f-90cc-4e0f-a773-dfe29d38f7d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "e0837175-dad5-43c9-949d-9afd80412d02", new DateTime(2020, 2, 16, 23, 28, 50, 332, DateTimeKind.Local).AddTicks(6956), "33a29d93-6849-44fe-bfba-2d9c06fabf25" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 335, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 335, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 335, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "EmployeeCustomers",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 337, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 335, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 334, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 334, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 334, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 334, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "fc3c4158-b6b4-4b8d-b9b6-4f5381e30292", new DateTime(2020, 2, 16, 23, 28, 50, 336, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "b57e61c6-88cf-47b5-b899-cf4144cdd4b3", new DateTime(2020, 2, 16, 23, 28, 50, 336, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "1",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 336, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "DateOfSale" },
                values: new object[] { new DateTime(2020, 2, 16, 23, 28, 50, 337, DateTimeKind.Local).AddTicks(1872), new DateTime(2020, 2, 16, 23, 28, 50, 337, DateTimeKind.Local).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "3",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 337, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "4",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 337, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "5",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 337, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "6",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 337, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "7",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 337, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedAt", "DateOfSale" },
                values: new object[] { new DateTime(2020, 2, 16, 23, 28, 50, 337, DateTimeKind.Local).AddTicks(1903), new DateTime(2020, 2, 16, 23, 28, 50, 337, DateTimeKind.Local).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 336, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 16, 23, 28, 50, 336, DateTimeKind.Local).AddTicks(4191));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "c500c609-9be8-4d9d-8c2f-096b7f69c0eb", new DateTime(2020, 2, 8, 17, 44, 18, 668, DateTimeKind.Local).AddTicks(776), "ec1f627f-8fe1-4f30-8efe-d3b841c7dec8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "08d7e0b6-f0e4-4867-9703-ab9469b4a769", new DateTime(2020, 2, 8, 17, 44, 18, 671, DateTimeKind.Local).AddTicks(5169), "a99fdfdb-8444-42c6-b7e4-9ee5e7c853cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "3ddcc9a1-7995-4886-9bbe-0d83a6aa2520", new DateTime(2020, 2, 8, 17, 44, 18, 671, DateTimeKind.Local).AddTicks(5278), "58f209a0-8548-4e4d-b6a9-acb026820a4f" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 674, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 674, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 674, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "EmployeeCustomers",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 675, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 673, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 674, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 674, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 674, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "d69523c4-2b4f-4a60-8c4e-911c65bd9e12", new DateTime(2020, 2, 8, 17, 44, 18, 675, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "2d9786b8-ab7a-4c8a-9851-62d891511683", new DateTime(2020, 2, 8, 17, 44, 18, 675, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "1",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "DateOfSale" },
                values: new object[] { new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7438), new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "3",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "4",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "5",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "6",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "7",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedAt", "DateOfSale" },
                values: new object[] { new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7471), new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 675, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(672));
        }
    }
}
