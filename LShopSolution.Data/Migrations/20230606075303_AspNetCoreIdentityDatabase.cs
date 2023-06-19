using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LShopSolution.Migrations
{
    public partial class AspNetCoreIdentityDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "365df97b-8b98-4b4c-94ad-6ac0d2e5ac2a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "DoB", "Email", "FirstName", "LastName", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "07dc7423-43a0-488a-9afa-6fbc55e4a8f6", new DateTime(2002, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "luantruong020302@gmail.com", "Luan", "Truong", "luantruong020302@gmail.com", "AQAAAAEAACcQAAAAEBIqrPFdqUNljVFbBNeezKwukvwOWZF6HkNn4smUUOfkA1sQ9XfBToJtmmEDw9saKw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 6, 6, 14, 53, 3, 124, DateTimeKind.Local).AddTicks(5331));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b441dbc8-c747-420f-a1a4-e85601f0fb8b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "DoB", "Email", "FirstName", "LastName", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "100f0034-13d6-4310-a45a-5895ba98bcb6", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedu.international@gmail.com", "Toan", "Bach", "tedu.international@gmail.com", "AQAAAAEAACcQAAAAEBQlvfdLPHaQqZjrDeom4/z5SSoXGGjMTfWO0o/IJK2O1Q101eWfUso1twbgd8Cinw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 6, 6, 14, 50, 28, 185, DateTimeKind.Local).AddTicks(5100));
        }
    }
}
