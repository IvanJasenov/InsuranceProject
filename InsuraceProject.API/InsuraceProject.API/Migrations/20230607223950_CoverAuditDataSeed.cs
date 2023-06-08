using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Claims.Migrations
{
    /// <inheritdoc />
    public partial class CoverAuditDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HttpRequestType",
                table: "CoverAudits",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoverId",
                table: "CoverAudits",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ClaimAudits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 6, 7, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "ClaimAudits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 5, 26, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "ClaimAudits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 6, 5, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "ClaimAudits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 6, 2, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.InsertData(
                table: "CoverAudits",
                columns: new[] { "Id", "CoverId", "Created", "HttpRequestType" },
                values: new object[,]
                {
                    { 1, "1", new DateTime(2023, 6, 7, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7801), "Https" },
                    { 2, "2", new DateTime(2023, 6, 4, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7803), "Https" },
                    { 3, "3", new DateTime(2023, 5, 28, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7804), "Https" },
                    { 4, "4", new DateTime(2023, 6, 2, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7805), "Https" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoverAudits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CoverAudits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CoverAudits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CoverAudits",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "HttpRequestType",
                table: "CoverAudits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CoverId",
                table: "CoverAudits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "ClaimAudits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 6, 7, 21, 37, 40, 160, DateTimeKind.Utc).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "ClaimAudits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 5, 26, 21, 37, 40, 160, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "ClaimAudits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 6, 5, 21, 37, 40, 160, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "ClaimAudits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 6, 2, 21, 37, 40, 160, DateTimeKind.Utc).AddTicks(710));
        }
    }
}
