using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrantTest.data.migrations
{
    /// <inheritdoc />
    public partial class DefaultProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 22, 22, 47, 17, 559, DateTimeKind.Local).AddTicks(8724), 499.99m, "SmartTv" },
                    { 2, new DateTime(2024, 1, 22, 22, 47, 17, 559, DateTimeKind.Local).AddTicks(8735), 599.99m, "Iphone" },
                    { 3, new DateTime(2024, 1, 22, 22, 47, 17, 559, DateTimeKind.Local).AddTicks(8736), 399.99m, "Laptop" },
                    { 4, new DateTime(2024, 1, 22, 22, 47, 17, 559, DateTimeKind.Local).AddTicks(8737), 59.99m, "HeadSet HyperX" },
                    { 5, new DateTime(2024, 1, 22, 22, 47, 17, 559, DateTimeKind.Local).AddTicks(8738), 49.99m, "Mouse HyperX" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
