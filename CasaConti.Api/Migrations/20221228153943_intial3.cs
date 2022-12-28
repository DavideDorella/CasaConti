using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarListApp.Api.Migrations
{
    public partial class intial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Conto",
                table: "Cars",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42358d3e-3c22-45e1-be81-6caa7ba865ef",
                column: "ConcurrencyStamp",
                value: "708cb626-c661-450c-b8d1-49d426b918d0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1b5952a-2162-46c7-b29e-1a2a68922c14",
                column: "ConcurrencyStamp",
                value: "7055b0a2-3c17-4d73-9838-37a39f1eddfd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4ef319c-e141-492d-b891-3112c61973d5", "AQAAAAEAACcQAAAAENrOiJdiZs6mj/Dj2O1nPw7bukivokDggK4nd7dpg+5iPyU7Z1dXG7i2F/doZVHN/w==", "7f3a601f-926d-48b3-ace7-27ad5fee3d4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b43a4ab-4f9f-47b5-8aff-48b1fc89e37e", "AQAAAAEAACcQAAAAEJL76tUmpwVyzsW2nHyh79YsxYHxStDLWPwgPAe6di7tK8ETf1lm5aJIa67MC7mGUw==", "1d4fbefd-e218-4cb8-b6d6-cdf1261b7471" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Conto",
                value: "a");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Conto",
                value: "a");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Conto",
                value: "a");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Conto",
                value: "a");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Conto",
                value: "a");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Conto",
                value: "a");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Conto",
                value: "a");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "Conto",
                value: "a");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "Conto",
                value: "a");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "Conto",
                value: "a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conto",
                table: "Cars");

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
        }
    }
}
