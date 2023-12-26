using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NTierECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class sampleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Products",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryDescription", "CategoryName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "IsActive", "MasterId", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "yazlık kışlık renkli renksiz giyim ürünleri", "giyim", "tanımsız", new DateTime(2023, 12, 26, 12, 14, 22, 489, DateTimeKind.Local).AddTicks(910), "tanımsız", true, new Guid("b8c776f6-0397-41c2-af02-17de26d4b9ff"), 0, "tanımsız", null, "tanımsız" },
                    { 2, "tablet telefon ürünleri", "teknoloji", "tanımsız", new DateTime(2023, 12, 26, 12, 14, 22, 489, DateTimeKind.Local).AddTicks(923), "tanımsız", true, new Guid("72a889ce-6c76-4bfc-a734-68ac4c7faf2c"), 0, "tanımsız", null, "tanımsız" },
                    { 3, "parfüm makyaj ürünleri", "kozmetik", "tanımsız", new DateTime(2023, 12, 26, 12, 14, 22, 489, DateTimeKind.Local).AddTicks(927), "tanımsız", true, new Guid("23647de5-5c77-4cd2-9cd4-b3df6da99e59"), 0, "tanımsız", null, "tanımsız" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "IsActive", "MasterId", "ProductName", "Status", "UnitPrice", "UnitsInStock", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, 1, "tanımsız", new DateTime(2023, 12, 26, 12, 14, 22, 489, DateTimeKind.Local).AddTicks(113), "tanımsız", null, true, new Guid("f1b483ee-c461-417d-97aa-3a5366c38ce1"), "nike airmax", 0, 400m, (short)500, "tanımsız", null, "tanımsız" },
                    { 2, 2, "tanımsız", new DateTime(2023, 12, 26, 12, 14, 22, 489, DateTimeKind.Local).AddTicks(153), "tanımsız", null, true, new Guid("9c504309-48ba-445e-b8af-3b040be33e30"), "lenova", 0, 20000m, (short)250, "tanımsız", null, "tanımsız" },
                    { 3, 3, "tanımsız", new DateTime(2023, 12, 26, 12, 14, 22, 489, DateTimeKind.Local).AddTicks(156), "tanımsız", null, true, new Guid("35a766ff-09f4-446b-a2d7-8e04e8af0b44"), "MAC Ruj", 0, 2000m, (short)250, "tanımsız", null, "tanımsız" }
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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Products",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
