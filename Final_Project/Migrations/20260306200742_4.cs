using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 3, 4, 22, 7, 39, 943, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 3, 4, 22, 7, 39, 943, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2026, 3, 5, 22, 7, 39, 943, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2026, 3, 5, 22, 7, 39, 943, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 3, 3, 22, 7, 39, 943, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 3, 3, 22, 7, 39, 943, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2026, 3, 2, 22, 7, 39, 943, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2026, 3, 2, 22, 7, 39, 943, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2026, 3, 1, 22, 7, 39, 943, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2026, 3, 1, 22, 7, 39, 943, DateTimeKind.Local).AddTicks(6847));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 3, 3, 16, 28, 46, 629, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 3, 3, 16, 28, 46, 629, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2026, 3, 4, 16, 28, 46, 629, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2026, 3, 4, 16, 28, 46, 629, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 3, 2, 16, 28, 46, 629, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 3, 2, 16, 28, 46, 629, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2026, 3, 1, 16, 28, 46, 629, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2026, 3, 1, 16, 28, 46, 629, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2026, 2, 28, 16, 28, 46, 629, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2026, 2, 28, 16, 28, 46, 629, DateTimeKind.Local).AddTicks(3745));
        }
    }
}
