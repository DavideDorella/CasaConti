using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarListApp.Api.Migrations
{
    public partial class initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Cars",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42358d3e-3c22-45e1-be81-6caa7ba865ef",
                column: "ConcurrencyStamp",
                value: "65d981a2-49a7-4436-9289-c3ae92a14aa4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1b5952a-2162-46c7-b29e-1a2a68922c14",
                column: "ConcurrencyStamp",
                value: "51e5709c-4bb4-4733-8984-c36c8923d068");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6a45f2e-9104-4b96-acbb-151cecdc21c8", "AQAAAAEAACcQAAAAEKnMlYoYXT+gDUmbGMA8lWOW6Nw6I6u6HgWPob0fkWDeHqfo8woetrI22IZh18V0CQ==", "83724192-f021-40ee-a5d3-15d85aedf39a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac13fa34-dc2d-4ff7-ba3b-6e0abf8ed316", "AQAAAAEAACcQAAAAECnzLG+Q20jWuTtzc7wGpUi6tBh4L66ZmdBHCEXS9gEhlFkWOhQkjZ6rmC4TGAE4tA==", "43690815-5cc9-48a9-a069-7f848663bd85" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42358d3e-3c22-45e1-be81-6caa7ba865ef",
                column: "ConcurrencyStamp",
                value: "db1023a6-6bec-4336-beac-a168692c7cdb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1b5952a-2162-46c7-b29e-1a2a68922c14",
                column: "ConcurrencyStamp",
                value: "1d5d8bda-5c06-4209-866b-ad515af3e8ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dedc4850-7b4e-48ce-b1aa-6f54c3b15f93", "AQAAAAEAACcQAAAAEAsp6liL6Qx63W9OfMjvribBLZe2vdPDrptt8ZUSda4tAEjQRmMj0M4XHzg0vuaVsQ==", "0d781601-fbea-4bf0-ad52-3a9f01e6e116" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70b359d5-e7e6-4871-99bc-a06cde76bebf", "AQAAAAEAACcQAAAAEPVLBqNQwJQM9+wPVd9Lb5rv399Koc4nwIb2jkTi1DWWQrktGQj/+BqHjq5E9TXAMQ==", "733be6e6-6174-4246-b7d0-0c5294e9a504" });
        }
    }
}
