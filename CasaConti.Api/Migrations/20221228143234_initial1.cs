using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarListApp.Api.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Desspesa",
                table: "Cars",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42358d3e-3c22-45e1-be81-6caa7ba865ef",
                column: "ConcurrencyStamp",
                value: "546d510e-634a-4476-b596-025cb4868579");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1b5952a-2162-46c7-b29e-1a2a68922c14",
                column: "ConcurrencyStamp",
                value: "6fcdc5ba-e31a-44a0-88b8-c8d8a71013d6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e2cdfe7-a127-4cc1-ab16-403c1568236e", "AQAAAAEAACcQAAAAEOTQFhUG1IUWkFLqu0SpZNcYXyQlwLgX9auUufv/zAXkHVooCUetW4aU5WjeLsojsw==", "9b5c807e-5831-4699-a0ea-5f3295dc4582" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1b5fe4f-73e6-4f0e-9ba3-1a9af40c29a3", "AQAAAAEAACcQAAAAEAZegAD5OV8nNYXMr/k/wXvW+hc91SJOy4tdayoWA6BYCdIqRGXhJrtjAPM/stp+lA==", "3aade29a-7ac8-4ac7-ba2c-3f251f8baf98" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Desspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Desspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Desspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Desspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Desspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Desspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Desspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "Desspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "Desspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "Desspesa",
                value: "b");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desspesa",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42358d3e-3c22-45e1-be81-6caa7ba865ef",
                column: "ConcurrencyStamp",
                value: "e3e97345-2e91-4fb0-b1dd-41974106ea09");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1b5952a-2162-46c7-b29e-1a2a68922c14",
                column: "ConcurrencyStamp",
                value: "fa019825-7152-4b7d-a941-f1c236e18e79");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "900c6f91-0a36-4308-8659-ddcecf72e514", "AQAAAAEAACcQAAAAEIicUPLs+f8D+V70zWQbuGRTetmFFe1qxXOApjlO8mAGKuOFTEjfobzPi8Z+I/dPXg==", "7ab05f5b-a261-423b-8b3b-b82d3d7bb3dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b1dcbc2-1bca-4bf3-98b2-aecb95f29267", "AQAAAAEAACcQAAAAEG2Q7Dl6XBe6DcguCmkvq5oAYMwV/enrnUuj7lqQkmDh7uXI0R7zRWq9DbQn61XZhQ==", "c3c36c9a-a927-4d27-9f17-6ce54af0f7fb" });
        }
    }
}
