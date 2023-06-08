using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Claims.Migrations
{
    /// <inheritdoc />
    public partial class AddDamageCost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DamageCost",
                table: "ClaimAudits",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "ClaimAudits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "DamageCost" },
                values: new object[] { new DateTime(2023, 6, 8, 10, 15, 2, 48, DateTimeKind.Utc).AddTicks(5018), 122.22m });

            migrationBuilder.UpdateData(
                table: "ClaimAudits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "DamageCost" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 15, 2, 48, DateTimeKind.Utc).AddTicks(5026), 5.2m });

            migrationBuilder.UpdateData(
                table: "ClaimAudits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "DamageCost" },
                values: new object[] { new DateTime(2023, 6, 6, 10, 15, 2, 48, DateTimeKind.Utc).AddTicks(5034), 34.13m });

            migrationBuilder.UpdateData(
                table: "ClaimAudits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "DamageCost" },
                values: new object[] { new DateTime(2023, 6, 3, 10, 15, 2, 48, DateTimeKind.Utc).AddTicks(5035), 0m });

            migrationBuilder.UpdateData(
                table: "CoverAudits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 6, 8, 10, 15, 2, 48, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "CoverAudits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 6, 5, 10, 15, 2, 48, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "CoverAudits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 5, 29, 10, 15, 2, 48, DateTimeKind.Utc).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "CoverAudits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 6, 3, 10, 15, 2, 48, DateTimeKind.Utc).AddTicks(5207));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DamageCost",
                table: "ClaimAudits");

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

            migrationBuilder.UpdateData(
                table: "CoverAudits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 6, 7, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "CoverAudits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 6, 4, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "CoverAudits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 5, 28, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "CoverAudits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 6, 2, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7805));
        }
    }
}
