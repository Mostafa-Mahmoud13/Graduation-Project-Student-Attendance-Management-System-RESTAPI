using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class hl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResetToken",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TokenExpiry",
                table: "Students",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResetToken",
                table: "Professors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TokenExpiry",
                table: "Professors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 4, 4, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 4, 4, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2026, 4, 5, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2026, 4, 5, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 4, 3, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 4, 3, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2026, 4, 2, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2026, 4, 2, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2026, 4, 1, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2026, 4, 1, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2026, 4, 5, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2026, 4, 4, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2026, 4, 3, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2026, 4, 2, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2026, 4, 4, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2026, 4, 5, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2026, 4, 4, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2026, 4, 3, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2026, 4, 5, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2026, 4, 4, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2026, 4, 3, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2026, 4, 5, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2026, 4, 4, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2026, 4, 3, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2026, 4, 5, 18, 28, 44, 322, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 1,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 2,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 3,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 4,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 5,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 6,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 7,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 8,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 9,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 1,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 2,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 3,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 4,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 5,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 6,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 7,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 8,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 9,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 10,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 11,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 12,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 13,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 14,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 15,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 16,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 17,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 18,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 19,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 20,
                columns: new[] { "ResetToken", "TokenExpiry" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResetToken",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TokenExpiry",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ResetToken",
                table: "Professors");

            migrationBuilder.DropColumn(
                name: "TokenExpiry",
                table: "Professors");

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 4, 4, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 4, 4, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2026, 4, 5, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2026, 4, 5, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 4, 3, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 4, 3, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2026, 4, 2, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2026, 4, 2, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2026, 4, 1, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2026, 4, 1, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2026, 4, 5, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2026, 4, 4, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2026, 4, 3, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2026, 4, 2, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2026, 4, 4, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2026, 4, 5, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2026, 4, 4, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2026, 4, 3, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2026, 4, 5, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2026, 4, 4, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2026, 4, 3, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2026, 4, 5, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2026, 4, 4, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2026, 4, 3, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2026, 4, 5, 18, 22, 16, 250, DateTimeKind.Local).AddTicks(8560));
        }
    }
}
