using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductApp.Migrations
{
    public partial class Roless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39d2bd15-675c-4326-a242-ffb234ee9347");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b08e94f-b86e-40d7-867e-5024bb5579d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74671d28-7b65-4358-8f34-174bd61c311e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d7c0f71-6683-42cd-8ab1-ee978b8c3b39", "8d2de7b6-5e36-4570-8c4e-1daaed940e5e", "Admin", "ADMIN" },
                    { "397bf556-7d95-4e1b-8694-73092c128309", "4f07c239-66cc-4867-9a50-e0758060096d", "Editor", "EDITOR" },
                    { "9f02d1d4-60fe-432e-bbe4-34bf3744d13a", "23f13b6a-d14d-41c0-8d7d-0471a3157c5f", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AtCreated",
                value: new DateTime(2022, 12, 18, 10, 57, 40, 748, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AtCreated",
                value: new DateTime(2022, 12, 18, 10, 57, 40, 748, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AtCreated",
                value: new DateTime(2022, 12, 18, 10, 57, 40, 748, DateTimeKind.Local).AddTicks(9635));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d7c0f71-6683-42cd-8ab1-ee978b8c3b39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "397bf556-7d95-4e1b-8694-73092c128309");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f02d1d4-60fe-432e-bbe4-34bf3744d13a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "39d2bd15-675c-4326-a242-ffb234ee9347", "ab28623a-692f-4fc3-bfe1-af2c49b4682e", "Editor", "EDITOR" },
                    { "3b08e94f-b86e-40d7-867e-5024bb5579d0", "f34523a3-9094-489f-a9e4-f6dc79a90898", "Admin", "ADMIN" },
                    { "74671d28-7b65-4358-8f34-174bd61c311e", "06f869b8-89f2-4a5f-ac7f-0d4e5e8568a3", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AtCreated",
                value: new DateTime(2022, 12, 18, 10, 54, 2, 567, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AtCreated",
                value: new DateTime(2022, 12, 18, 10, 54, 2, 567, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AtCreated",
                value: new DateTime(2022, 12, 18, 10, 54, 2, 567, DateTimeKind.Local).AddTicks(3524));
        }
    }
}
