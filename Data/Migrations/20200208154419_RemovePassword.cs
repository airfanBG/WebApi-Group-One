using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class RemovePassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c500c609-9be8-4d9d-8c2f-096b7f69c0eb", new DateTime(2020, 2, 8, 17, 44, 18, 668, DateTimeKind.Local).AddTicks(776), "1234", "ec1f627f-8fe1-4f30-8efe-d3b841c7dec8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08d7e0b6-f0e4-4867-9703-ab9469b4a769", new DateTime(2020, 2, 8, 17, 44, 18, 671, DateTimeKind.Local).AddTicks(5169), "1234", "a99fdfdb-8444-42c6-b7e4-9ee5e7c853cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ddcc9a1-7995-4886-9bbe-0d83a6aa2520", new DateTime(2020, 2, 8, 17, 44, 18, 671, DateTimeKind.Local).AddTicks(5278), "1234", "58f209a0-8548-4e4d-b6a9-acb026820a4f" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "057d27c1-6aef-4876-91b2-62df403900c1", new DateTime(2020, 2, 8, 17, 10, 11, 519, DateTimeKind.Local).AddTicks(5715), "1234", null, "3934a7f7-03b3-4595-a75a-92d87c23d456" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76815a63-0cf9-4057-8119-13d69af5db98", new DateTime(2020, 2, 8, 17, 10, 11, 526, DateTimeKind.Local).AddTicks(3762), "1234", null, "1565486e-2c8c-4dad-8df3-7d983a32b1de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e77f242b-514f-4ed4-8c80-467844e914c0", new DateTime(2020, 2, 8, 17, 10, 11, 526, DateTimeKind.Local).AddTicks(3910), "1234", null, "f74bf841-2323-4b6f-9eda-4e0569328264" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 534, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 534, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 534, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "EmployeeCustomers",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 536, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 533, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 534, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 534, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 534, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "24dd233a-9b4d-4350-8aac-a4fa2e47ef5e", new DateTime(2020, 2, 8, 17, 10, 11, 536, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "009af38c-7cd1-4fbd-a756-e5abd36f1066", new DateTime(2020, 2, 8, 17, 10, 11, 536, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "1",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 537, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "DateOfSale" },
                values: new object[] { new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(4057), new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "3",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "4",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "5",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "6",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "7",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedAt", "DateOfSale" },
                values: new object[] { new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(4108), new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 536, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 8, 17, 10, 11, 537, DateTimeKind.Local).AddTicks(1063));
        }
    }
}
