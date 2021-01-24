using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mis.DataAccess.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 22, 13, 22, 47, 611, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 22, 13, 22, 47, 614, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName", "CreatedBy", "CreatedDate", "IsActive" },
                values: new object[] { 3, "Apple", 0, new DateTime(2021, 1, 22, 13, 22, 47, 614, DateTimeKind.Local).AddTicks(6991), true });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RamSlots", "UsbPorts" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RamSlots", "UsbPorts" },
                values: new object[] { 2, 10 });

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "Id", "FromFactorId", "RamSlots", "UsbPorts" },
                values: new object[] { 3, 1, 15, 0 });

            migrationBuilder.InsertData(
                table: "FromFactors",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "FromFactorName", "IsActive" },
                values: new object[,]
                {
                    { 2, 0, new DateTime(2021, 1, 22, 13, 22, 47, 616, DateTimeKind.Local).AddTicks(2535), "Mid-Tower", true },
                    { 1, 0, new DateTime(2021, 1, 22, 13, 22, 47, 616, DateTimeKind.Local).AddTicks(2165), "Tower", true }
                });

            migrationBuilder.InsertData(
                table: "Laptops",
                columns: new[] { "Id", "ScreenSize", "UsbPorts" },
                values: new object[,]
                {
                    { 4, 0, 2 },
                    { 5, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "PCBasedProducts",
                columns: new[] { "Id", "ProcessorId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 3 },
                    { 3, 6 },
                    { 5, 1 },
                    { 4, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 22, 13, 22, 47, 615, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 22, 13, 22, 47, 616, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 22, 13, 22, 47, 616, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 22, 13, 22, 47, 616, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 22, 13, 22, 47, 616, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.InsertData(
                table: "Processors",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "ProcessorName" },
                values: new object[] { 6, 0, new DateTime(2021, 1, 22, 13, 22, 47, 616, DateTimeKind.Local).AddTicks(190), true, "Xeon" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CreatedBy", "CreatedDate", "IsActive", "Quantity" },
                values: new object[,]
                {
                    { 5, 3, 0, new DateTime(2021, 1, 22, 13, 22, 47, 617, DateTimeKind.Local).AddTicks(9716), true, 100000 },
                    { 4, 2, 0, new DateTime(2021, 1, 22, 13, 22, 47, 617, DateTimeKind.Local).AddTicks(9714), true, 10000 },
                    { 3, 2, 0, new DateTime(2021, 1, 22, 13, 22, 47, 617, DateTimeKind.Local).AddTicks(9712), true, 1000 },
                    { 1, 1, 0, new DateTime(2021, 1, 22, 13, 22, 47, 617, DateTimeKind.Local).AddTicks(9095), true, 10 },
                    { 2, 1, 0, new DateTime(2021, 1, 22, 13, 22, 47, 617, DateTimeKind.Local).AddTicks(9702), true, 100 }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                column: "Id",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FromFactors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FromFactors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PCBasedProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PCBasedProducts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PCBasedProducts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PCBasedProducts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PCBasedProducts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 6);

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

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 22, 12, 50, 44, 122, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 22, 12, 50, 44, 125, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RamSlots", "UsbPorts" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RamSlots", "UsbPorts" },
                values: new object[] { 15, 20 });

            migrationBuilder.UpdateData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 22, 12, 50, 44, 127, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 22, 12, 50, 44, 127, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 22, 12, 50, 44, 127, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 22, 12, 50, 44, 127, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 1, 22, 12, 50, 44, 127, DateTimeKind.Local).AddTicks(395));
        }
    }
}
