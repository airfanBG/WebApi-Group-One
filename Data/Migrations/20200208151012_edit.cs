using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Roles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Roles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedName",
                table: "Roles",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "057d27c1-6aef-4876-91b2-62df403900c1", new DateTime(2020, 2, 8, 17, 10, 11, 519, DateTimeKind.Local).AddTicks(5715), "3934a7f7-03b3-4595-a75a-92d87c23d456" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "76815a63-0cf9-4057-8119-13d69af5db98", new DateTime(2020, 2, 8, 17, 10, 11, 526, DateTimeKind.Local).AddTicks(3762), "1565486e-2c8c-4dad-8df3-7d983a32b1de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "e77f242b-514f-4ed4-8c80-467844e914c0", new DateTime(2020, 2, 8, 17, 10, 11, 526, DateTimeKind.Local).AddTicks(3910), "f74bf841-2323-4b6f-9eda-4e0569328264" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "NormalizedName",
                table: "Roles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "9f2d972b-ad4a-4af4-b229-322bc9d8a301", new DateTime(2020, 2, 7, 13, 15, 46, 431, DateTimeKind.Local).AddTicks(9759), "3b2f70c0-e5b1-4e7e-9fa4-69e314a055d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "f3f6b8d3-1f6e-43b2-9847-ecfa79d988a0", new DateTime(2020, 2, 7, 13, 15, 46, 436, DateTimeKind.Local).AddTicks(8944), "48b28469-6878-41cb-926a-229041a532ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "96500971-710d-4d23-9102-ecbb23494459", new DateTime(2020, 2, 7, 13, 15, 46, 436, DateTimeKind.Local).AddTicks(9091), "d796d44a-991a-45d2-a9b9-abd83db4d9ad" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 440, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 440, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 440, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "EmployeeCustomers",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 443, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 441, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 439, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 440, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 440, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 440, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 441, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 441, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "1",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 442, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "DateOfSale" },
                values: new object[] { new DateTime(2020, 2, 7, 13, 15, 46, 443, DateTimeKind.Local).AddTicks(387), new DateTime(2020, 2, 7, 13, 15, 46, 443, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "3",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 443, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "4",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 443, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "5",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 443, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "6",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 443, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "7",
                column: "DateOfSale",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 443, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "SalesOrders",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedAt", "DateOfSale" },
                values: new object[] { new DateTime(2020, 2, 7, 13, 15, 46, 443, DateTimeKind.Local).AddTicks(440), new DateTime(2020, 2, 7, 13, 15, 46, 443, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 441, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "CreatedAt",
                value: new DateTime(2020, 2, 7, 13, 15, 46, 442, DateTimeKind.Local).AddTicks(888));
        }
    }
}
