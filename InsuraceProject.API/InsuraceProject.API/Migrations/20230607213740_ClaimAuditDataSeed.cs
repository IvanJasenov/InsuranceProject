using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Claims.Migrations
{
    /// <inheritdoc />
    public partial class ClaimAuditDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HttpRequestType",
                table: "CoverAudits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CoverId",
                table: "CoverAudits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HttpRequestType",
                table: "ClaimAudits",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ClaimId",
                table: "ClaimAudits",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "ClaimAudits",
                columns: new[] { "Id", "ClaimId", "Created", "HttpRequestType" },
                values: new object[,]
                {
                    { 1, "1", new DateTime(2023, 6, 7, 21, 37, 40, 160, DateTimeKind.Utc).AddTicks(698), "Https" },
                    { 2, "2", new DateTime(2023, 5, 26, 21, 37, 40, 160, DateTimeKind.Utc).AddTicks(702), "Https" },
                    { 3, "3", new DateTime(2023, 6, 5, 21, 37, 40, 160, DateTimeKind.Utc).AddTicks(708), "Https" },
                    { 4, "4", new DateTime(2023, 6, 2, 21, 37, 40, 160, DateTimeKind.Utc).AddTicks(710), "Https" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClaimAudits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClaimAudits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClaimAudits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClaimAudits",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "HttpRequestType",
                table: "CoverAudits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoverId",
                table: "CoverAudits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HttpRequestType",
                table: "ClaimAudits",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "ClaimId",
                table: "ClaimAudits",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);
        }
    }
}
