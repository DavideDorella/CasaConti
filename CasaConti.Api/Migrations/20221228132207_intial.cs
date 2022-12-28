using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarListApp.Api.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Catspesa",
                table: "Cars",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Catspesa",
                value: "a");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Catspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Catspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Catspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Catspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Catspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Catspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "Catspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "Catspesa",
                value: "b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "Catspesa",
                value: "b");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Catspesa",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42358d3e-3c22-45e1-be81-6caa7ba865ef",
                column: "ConcurrencyStamp",
                value: "4ead6e79-84b4-4a80-b0e1-dc4006a233de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1b5952a-2162-46c7-b29e-1a2a68922c14",
                column: "ConcurrencyStamp",
                value: "fc3acd77-dc02-4553-a71e-d7020a16a569");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "817a9d48-83e4-44f5-9d3b-e9a4819ce3fe", "AQAAAAEAACcQAAAAEFJbxKluFqbCpZQZHoi0HzQZltt4dV/RU/HaC1L9qqABT7Mh0M8e4SDiL4ELavqMtw==", "a96ccbd7-5608-4a56-b38c-45725850eb71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b81255b9-0e99-41e2-9ea5-9c9c2b193f4c", "AQAAAAEAACcQAAAAEK7Bt9mF1ZbBeFbOer1RI4Pdw0OL3vOG/jSspdPkzyBaEPoUyAV4BS5vqSuGlcnf1Q==", "da100006-0caa-4be2-b515-2ea21d086ff7" });
        }
    }
}
