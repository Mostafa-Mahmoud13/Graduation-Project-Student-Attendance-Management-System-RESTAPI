using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 3, 14, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 3, 14, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2026, 3, 15, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2026, 3, 15, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 3, 13, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 3, 13, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2026, 3, 12, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2026, 3, 12, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2026, 3, 11, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2026, 3, 11, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "Professor_id", "Department", "Email", "Gender", "Password", "Phone", "Pro_Name", "Pro_code", "Role" },
                values: new object[,]
                {
                    { 7, "CS", "hassan@gmail.com", "Male", "hassan123", 2333333333L, "Dr. Hassan", 207, "Professor" },
                    { 8, "IT", "rania@gmail.com", "Female", "rania123", 2444444444L, "Dr. Rania", 208, "Professor" },
                    { 9, "IS", "khaled@gmail.com", "Male", "khaled123", 2555555555L, "Dr. Khaled", 209, "Professor" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Student_id", "Department", "Email", "Gender", "Password", "Phone", "Role", "St_Name", "St_code" },
                values: new object[,]
                {
                    { 6, "IT", "omar@gmail.com", "Male", "omar123", 1222333444L, "Student", "Omar", 116 },
                    { 7, "CS", "mariam@gmail.com", "Female", "mariam123", 1333444555L, "Student", "Mariam", 117 },
                    { 8, "IS", "khaled@gmail.com", "Male", "khaled123", 1444555666L, "Student", "Khaled", 118 },
                    { 9, "CS", "hana@gmail.com", "Female", "hana123", 1555666777L, "Student", "Hana", 119 },
                    { 10, "IT", "mahmoud@gmail.com", "Male", "mahmoud123", 1666777888L, "Student", "Mahmoud", 120 },
                    { 11, "CS", "ali@gmail.com", "Male", "ali123", 1777888999L, "Student", "Ali", 121 },
                    { 12, "IT", "fatma@gmail.com", "Female", "fatma123", 1888999000L, "Student", "Fatma", 122 },
                    { 13, "IS", "ibrahim@gmail.com", "Male", "ibrahim123", 1999000111L, "Student", "Ibrahim", 123 },
                    { 14, "CS", "nour@gmail.com", "Female", "nour123", 2000111222L, "Student", "Nour", 124 },
                    { 15, "IT", "yara@gmail.com", "Female", "yara123", 2111222333L, "Student", "Yara", 125 },
                    { 16, "CS", "amr@gmail.com", "Male", "amr123", 2222333444L, "Student", "Amr", 126 },
                    { 17, "IS", "salem@gmail.com", "Male", "salem123", 2333444555L, "Student", "Salem", 127 },
                    { 18, "CS", "laila@gmail.com", "Female", "laila123", 2444555666L, "Student", "Laila", 128 },
                    { 19, "IT", "karim@gmail.com", "Male", "karim123", 2555666777L, "Student", "Karim", 129 },
                    { 20, "CS", "hossam@gmail.com", "Male", "hossam123", 2666777888L, "Student", "Hossam", 130 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Sub_ID", "Professor_Id", "Sub_Code", "Sub_Name" },
                values: new object[,]
                {
                    { 6, 1, "CS303", "Operating Systems" },
                    { 7, 6, "CS404", "Artificial Intelligence" },
                    { 8, 2, "IT305", "Web Development" }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "Date", "Present", "Professor_Id", "Student_Id", "Subject_Id" },
                values: new object[,]
                {
                    { 11, new DateTime(2026, 3, 15, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4729), true, 1, 6, 6 },
                    { 12, new DateTime(2026, 3, 14, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4731), false, 6, 7, 7 },
                    { 13, new DateTime(2026, 3, 13, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4732), true, 3, 8, 5 },
                    { 14, new DateTime(2026, 3, 12, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4734), true, 4, 9, 2 },
                    { 15, new DateTime(2026, 3, 14, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4736), false, 2, 10, 8 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Sub_ID", "Professor_Id", "Sub_Code", "Sub_Name" },
                values: new object[,]
                {
                    { 9, 7, "CS405", "Machine Learning" },
                    { 10, 8, "IT402", "Cloud Computing" },
                    { 11, 9, "IS404", "Cyber Security" },
                    { 12, 7, "CS350", "Software Engineering" }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "Date", "Present", "Professor_Id", "Student_Id", "Subject_Id" },
                values: new object[,]
                {
                    { 16, new DateTime(2026, 3, 15, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4738), true, 7, 11, 9 },
                    { 17, new DateTime(2026, 3, 14, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4740), false, 8, 12, 10 },
                    { 18, new DateTime(2026, 3, 13, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4743), true, 9, 13, 11 },
                    { 19, new DateTime(2026, 3, 15, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4745), true, 7, 14, 12 },
                    { 20, new DateTime(2026, 3, 14, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4746), false, 7, 15, 9 },
                    { 21, new DateTime(2026, 3, 13, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4749), true, 8, 16, 10 },
                    { 22, new DateTime(2026, 3, 15, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4751), true, 9, 17, 11 },
                    { 23, new DateTime(2026, 3, 14, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4753), false, 7, 18, 12 },
                    { 24, new DateTime(2026, 3, 13, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4755), true, 7, 19, 9 },
                    { 25, new DateTime(2026, 3, 15, 23, 53, 7, 876, DateTimeKind.Local).AddTicks(4757), true, 8, 20, 10 }
                });

            migrationBuilder.InsertData(
                table: "StudentSubjects",
                columns: new[] { "Student_Id", "Subject_Id" },
                values: new object[,]
                {
                    { 11, 9 },
                    { 12, 10 },
                    { 13, 11 },
                    { 14, 12 },
                    { 15, 9 },
                    { 16, 10 },
                    { 17, 11 },
                    { 18, 12 },
                    { 19, 9 },
                    { 20, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "Student_Id", "Subject_Id" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "Student_Id", "Subject_Id" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "Student_Id", "Subject_Id" },
                keyValues: new object[] { 13, 11 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "Student_Id", "Subject_Id" },
                keyValues: new object[] { 14, 12 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "Student_Id", "Subject_Id" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "Student_Id", "Subject_Id" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "Student_Id", "Subject_Id" },
                keyValues: new object[] { 17, 11 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "Student_Id", "Subject_Id" },
                keyValues: new object[] { 18, 12 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "Student_Id", "Subject_Id" },
                keyValues: new object[] { 19, 9 });

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumns: new[] { "Student_Id", "Subject_Id" },
                keyValues: new object[] { 20, 10 });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Student_id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Sub_ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Sub_ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Sub_ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Sub_ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Sub_ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Sub_ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Sub_ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Professor_id",
                keyValue: 9);

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
    }
}
