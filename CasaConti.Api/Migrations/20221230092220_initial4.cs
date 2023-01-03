using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarListApp.Api.Migrations
{
    public partial class initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Importo",
                table: "Cars",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Importo",
                table: "Cars");

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
        }
    }
}
