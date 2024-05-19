using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECom.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class datemorestockchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 16,
                column: "Quantity",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 16,
                column: "Quantity",
                value: 70);
        }
    }
}
