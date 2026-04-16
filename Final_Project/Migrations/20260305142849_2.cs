using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Professors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 1,
                column: "Role",
                value: "Professor");

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 2,
                column: "Role",
                value: "Professor");

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 3,
                column: "Role",
                value: "Professor");

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 4,
                column: "Role",
                value: "Professor");

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 5,
                column: "Role",
                value: "Professor");

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 6,
                column: "Role",
                value: "Professor");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 1,
                column: "Role",
                value: "Student");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 2,
                column: "Role",
                value: "Student");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 3,
                column: "Role",
                value: "Student");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 4,
                column: "Role",
                value: "Student");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 5,
                column: "Role",
                value: "Student");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Professors");

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 12, 4, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 12, 4, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 12, 5, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 12, 5, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 12, 3, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 12, 3, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 12, 2, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 12, 2, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 12, 1, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 12, 1, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8776));
        }
    }
}
