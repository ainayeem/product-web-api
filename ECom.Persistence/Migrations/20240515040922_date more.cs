using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECom.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class datemore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SearchEngineFriendlyName = table.Column<string>(type: "text", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Variants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: false),
                    Size = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VariantId = table.Column<int>(type: "integer", nullable: false),
                    WarehouseId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_Variants_VariantId",
                        column: x => x.VariantId,
                        principalTable: "Variants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stocks_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedOn", "Name", "SearchEngineFriendlyName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7745), "Summer T-Shirt", "summer-t-shirt-male" },
                    { 2, new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7748), "Summer Pant", "summer-pant-male" },
                    { 3, new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7749), "Summer Shirt", "summer-shirt-male" },
                    { 4, new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7750), "Winter T-Shirt", "winter-t-shirt-male" },
                    { 5, new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7751), "Winter Shirt", "winter-shirt-male" },
                    { 6, new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7752), "Spring Jacket", "spring-jacket-female" },
                    { 7, new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7753), "Autumn Scarf", "autumn-scarf-unisex" },
                    { 8, new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7754), "Summer Dress", "summer-dress-female" },
                    { 9, new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7755), "Winter Coat", "winter-coat-female" },
                    { 10, new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7756), "Spring Skirt", "spring-skirt-female" },
                    { 11, new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7756), "Autumn Sweater", "autumn-sweater-male" },
                    { 12, new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7757), "Winter Boots", "winter-boots-unisex" },
                    { 13, new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7758), "Spring Hat", "spring-hat-unisex" },
                    { 14, new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7759), "Summer Sandals", "summer-sandals-female" },
                    { 15, new DateTime(2024, 5, 15, 4, 9, 22, 113, DateTimeKind.Utc).AddTicks(7760), "Autumn Jacket", "autumn-jacket-male" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Dhaka", "Dhaka Warehouse" },
                    { 2, "Chittagong", "Chittagong Warehouse" },
                    { 3, "Khulna", "Khulna Warehouse" },
                    { 4, "Rajshahi", "Rajshahi Warehouse" }
                });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "Id", "Color", "ProductId", "Size" },
                values: new object[,]
                {
                    { 1, "Red", 1, "Small" },
                    { 2, "Blue", 1, "Medium" },
                    { 3, "Green", 2, "Large" },
                    { 4, "Yellow", 3, "Small" },
                    { 5, "Black", 4, "Medium" },
                    { 6, "White", 5, "Large" },
                    { 7, "Pink", 6, "Small" },
                    { 8, "Brown", 7, "One Size" },
                    { 9, "Orange", 8, "Medium" },
                    { 10, "Gray", 9, "Large" },
                    { 11, "Purple", 10, "Small" },
                    { 12, "Maroon", 11, "Medium" },
                    { 13, "Black", 12, "Large" },
                    { 14, "White", 13, "One Size" },
                    { 15, "Blue", 14, "Small" },
                    { 16, "Green", 15, "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "Quantity", "VariantId", "WarehouseId" },
                values: new object[,]
                {
                    { 1, 10, 1, 1 },
                    { 2, 5, 2, 1 },
                    { 3, 20, 3, 2 },
                    { 4, 15, 4, 2 },
                    { 5, 25, 5, 3 },
                    { 6, 30, 6, 3 },
                    { 7, 12, 7, 1 },
                    { 8, 7, 8, 1 },
                    { 9, 22, 9, 2 },
                    { 10, 18, 10, 2 },
                    { 11, 30, 11, 3 },
                    { 12, 40, 12, 3 },
                    { 13, 50, 13, 1 },
                    { 14, 10, 14, 2 },
                    { 15, 60, 15, 3 },
                    { 16, 70, 16, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_VariantId",
                table: "Stocks",
                column: "VariantId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_WarehouseId",
                table: "Stocks",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Variants_ProductId",
                table: "Variants",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Variants");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
