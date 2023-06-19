using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LShopSolution.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "2cd2ece7-046a-4db9-b056-103224d3532b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "26657894-a6b7-4efd-bf8a-e124e918b8b8", "AQAAAAEAACcQAAAAEERMUN1KeaIXg5eKzkuPyXa6W9VJ1cWFyczTc8FFeVwLx+vEjRbk2kvVDplH1/dm8g==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 6, 7, 23, 5, 13, 697, DateTimeKind.Local).AddTicks(2371));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e3d5bfb8-8553-456c-aaff-3ce39acb05f7");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "93a512b1-5783-445f-8f3e-3f52b1d6b679", "AQAAAAEAACcQAAAAEEIsmSX6grbcDGT55fBvhooscT/7fp6fKYHTZ0hgLmYK9k7kftziage4rMXZGdXSZQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 6, 7, 19, 33, 39, 518, DateTimeKind.Local).AddTicks(7082));
        }
    }
}
