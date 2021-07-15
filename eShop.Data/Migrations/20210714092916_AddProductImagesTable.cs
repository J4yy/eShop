using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class AddProductImagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "7c914a5a-4807-4bab-a6d5-eb2da5b630e7");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b34ad43c-ff50-4e1d-8b91-72720acf77f4", "AQAAAAEAACcQAAAAEDq/SzhQLQf1N/qpTNdEHdl10D49wiEGMF1qDBRqyeAmi9rQFM8wpN7GBNJTOCIhRg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 14, 16, 29, 15, 820, DateTimeKind.Local).AddTicks(6354));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "5b099517-d450-4e92-932f-6e9e33ea046c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ccc81349-a3fe-43ec-a0c9-89dcc0f3c60a", "AQAAAAEAACcQAAAAEJbV7O26dKrTClJSCbWZp0G/tNBMtHew33iHkqTaqZyw/ebO3ZFpQvWFXkidkXnt8Q==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 14, 2, 30, 11, 19, DateTimeKind.Local).AddTicks(8069));
        }
    }
}
