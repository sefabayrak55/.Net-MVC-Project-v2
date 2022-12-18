using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductApp.Migrations
{
    public partial class Roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12ea6f88-00e8-4f75-859e-95867275ec46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "342ef635-b912-4bce-a072-427caabc1278");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63f56e3b-236e-4d36-82cb-a995576bf40f");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "12ea6f88-00e8-4f75-859e-95867275ec46", "4f24c6e6-0e42-40ba-a839-8da6a1668a0c", "User", null },
                    { "342ef635-b912-4bce-a072-427caabc1278", "f4520318-a8c5-46cd-ad1f-775332081508", "Admin", null },
                    { "63f56e3b-236e-4d36-82cb-a995576bf40f", "712b3c06-b0a0-4dab-9ff2-e146464ba123", "Editor", null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AtCreated",
                value: new DateTime(2022, 12, 17, 11, 52, 23, 528, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AtCreated",
                value: new DateTime(2022, 12, 17, 11, 52, 23, 528, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AtCreated",
                value: new DateTime(2022, 12, 17, 11, 52, 23, 528, DateTimeKind.Local).AddTicks(477));
        }
    }
}
