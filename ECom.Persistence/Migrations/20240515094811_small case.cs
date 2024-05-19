using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECom.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class smallcase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 48, 10, 106, DateTimeKind.Utc).AddTicks(6504), "summer t-shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 48, 10, 106, DateTimeKind.Utc).AddTicks(6508), "summer pant" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 48, 10, 106, DateTimeKind.Utc).AddTicks(6509), "summer shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 48, 10, 106, DateTimeKind.Utc).AddTicks(6510), "winter t-shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 48, 10, 106, DateTimeKind.Utc).AddTicks(6511), "winter shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 48, 10, 106, DateTimeKind.Utc).AddTicks(6512), "spring jacket" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 48, 10, 106, DateTimeKind.Utc).AddTicks(6513), "autumn scarf" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 48, 10, 106, DateTimeKind.Utc).AddTicks(6514), "summer dress" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 48, 10, 106, DateTimeKind.Utc).AddTicks(6515), "winter coat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 48, 10, 106, DateTimeKind.Utc).AddTicks(6516), "spring skirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 48, 10, 106, DateTimeKind.Utc).AddTicks(6517), "autumn sweater" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 48, 10, 106, DateTimeKind.Utc).AddTicks(6518), "winter boots" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 48, 10, 106, DateTimeKind.Utc).AddTicks(6518), "spring hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 48, 10, 106, DateTimeKind.Utc).AddTicks(6519), "summer sandals" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 48, 10, 106, DateTimeKind.Utc).AddTicks(6520), "autumn jacket" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "Size" },
                values: new object[] { "red", "small" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Size" },
                values: new object[] { "blue", "medium" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "Size" },
                values: new object[] { "green", "large" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "Size" },
                values: new object[] { "yellow", "small" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "Size" },
                values: new object[] { "black", "medium" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "Size" },
                values: new object[] { "white", "large" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "Size" },
                values: new object[] { "pink", "small" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "Size" },
                values: new object[] { "brown", "one size" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "Size" },
                values: new object[] { "orange", "medium" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Color", "Size" },
                values: new object[] { "gray", "large" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Color", "Size" },
                values: new object[] { "purple", "small" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Color", "Size" },
                values: new object[] { "maroon", "medium" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Color", "Size" },
                values: new object[] { "black", "large" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Color", "Size" },
                values: new object[] { "white", "one size" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Color", "Size" },
                values: new object[] { "blue", "small" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Color", "Size" },
                values: new object[] { "green", "medium" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Location", "Name" },
                values: new object[] { "dhaka", "dhaka warehouse" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Location", "Name" },
                values: new object[] { "chittagong", "chittagong warehouse" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Location", "Name" },
                values: new object[] { "khulna", "khulna warehouse" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Location", "Name" },
                values: new object[] { "rajshahi", "rajshahi warehouse" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1852), "Summer T-Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1856), "Summer Pant" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1857), "Summer Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1858), "Winter T-Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1859), "Winter Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1860), "Spring Jacket" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1863), "Autumn Scarf" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1864), "Summer Dress" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1865), "Winter Coat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1865), "Spring Skirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1866), "Autumn Sweater" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1867), "Winter Boots" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1868), "Spring Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1869), "Summer Sandals" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1870), "Autumn Jacket" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Red", "Small" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Blue", "Medium" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Green", "Large" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Yellow", "Small" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "Medium" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "Size" },
                values: new object[] { "White", "Large" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Pink", "Small" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Brown", "One Size" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Orange", "Medium" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Gray", "Large" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Purple", "Small" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Maroon", "Medium" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Black", "Large" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Color", "Size" },
                values: new object[] { "White", "One Size" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Blue", "Small" });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Color", "Size" },
                values: new object[] { "Green", "Medium" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Dhaka", "Dhaka Warehouse" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Chittagong", "Chittagong Warehouse" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Khulna", "Khulna Warehouse" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Rajshahi", "Rajshahi Warehouse" });
        }
    }
}
