using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class frist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professors",
                columns: table => new
                {
                    Professor_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pro_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pro_code = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professors", x => x.Professor_id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Student_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    St_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<long>(type: "bigint", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    St_code = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Student_id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Sub_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sub_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sub_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Professor_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Sub_ID);
                    table.ForeignKey(
                        name: "FK_Subjects_Professors_Professor_Id",
                        column: x => x.Professor_Id,
                        principalTable: "Professors",
                        principalColumn: "Professor_id");
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Present = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Student_Id = table.Column<int>(type: "int", nullable: false),
                    Subject_Id = table.Column<int>(type: "int", nullable: false),
                    Professor_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_Professors_Professor_Id",
                        column: x => x.Professor_Id,
                        principalTable: "Professors",
                        principalColumn: "Professor_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_Student_Id",
                        column: x => x.Student_Id,
                        principalTable: "Students",
                        principalColumn: "Student_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Subjects_Subject_Id",
                        column: x => x.Subject_Id,
                        principalTable: "Subjects",
                        principalColumn: "Sub_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubjects",
                columns: table => new
                {
                    Student_Id = table.Column<int>(type: "int", nullable: false),
                    Subject_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubjects", x => new { x.Student_Id, x.Subject_Id });
                    table.ForeignKey(
                        name: "FK_StudentSubjects_Students_Student_Id",
                        column: x => x.Student_Id,
                        principalTable: "Students",
                        principalColumn: "Student_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubjects_Subjects_Subject_Id",
                        column: x => x.Subject_Id,
                        principalTable: "Subjects",
                        principalColumn: "Sub_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "Professor_id", "Department", "Email", "Gender", "Password", "Phone", "Pro_Name", "Pro_code" },
                values: new object[,]
                {
                    { 1, "CS", "ahmed@gmail.com", "Male", "pass123", 1253456789L, "Dr. Ahmed", 201 },
                    { 2, "IT", "mona@gmail.com", "Female", "mona321", 1287654321L, "Dr. Mona", 202 },
                    { 3, "IS", "tarek@gmail.com", "Male", "tarek456", 1171222333L, "Dr. Tarek", 203 },
                    { 4, "CS", "salma@gmail.com", "Female", "salma789", 1284555666L, "Dr. Salma", 204 },
                    { 5, "IT", "mostafa@gmail.com", "Male", "mostafa000", 1077888999L, "Dr. Mostafa", 205 },
                    { 6, "CS", "lina@gmail.com", "Female", "lina123", 222333444L, "Dr. Lina", 206 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Student_id", "Department", "Email", "Gender", "Password", "Phone", "St_Name", "St_code" },
                values: new object[,]
                {
                    { 1, "CS", "mostafa@gmail.com", "Male", "123456", 1234567894L, "Mostafa", 111 },
                    { 2, "IT", "sara@gmail.com", "Female", "abcdef", 1098765432L, "Sara", 112 },
                    { 3, "CS", "youssef@gmail.com", "Male", "pass123", 1112223335L, "Youssef", 113 },
                    { 4, "IS", "nada@gmail.com", "Female", "nada321", 1244555666L, "Nada", 114 },
                    { 5, "CS", "ahmed@gmail.com", "Male", "omar789", 1577888999L, "Ahmed", 115 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Sub_ID", "Professor_Id", "Sub_Code", "Sub_Name" },
                values: new object[,]
                {
                    { 1, 1, "CS101", "OOP" },
                    { 2, 4, "CS102", "Databases" },
                    { 3, 2, "IT201", "Networks" },
                    { 4, 6, "CS202", "Algorithms" },
                    { 5, 3, "IS301", "Information Security" }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "Date", "Present", "Professor_Id", "Student_Id", "Subject_Id" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 4, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8742), true, 1, 1, 1 },
                    { 2, new DateTime(2025, 12, 4, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8760), false, 1, 2, 1 },
                    { 3, new DateTime(2025, 12, 5, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8762), true, 4, 3, 2 },
                    { 4, new DateTime(2025, 12, 5, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8764), true, 4, 4, 2 },
                    { 5, new DateTime(2025, 12, 3, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8766), false, 2, 5, 3 },
                    { 6, new DateTime(2025, 12, 3, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8769), true, 2, 1, 3 },
                    { 7, new DateTime(2025, 12, 2, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8770), true, 6, 2, 4 },
                    { 8, new DateTime(2025, 12, 2, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8772), false, 6, 3, 4 },
                    { 9, new DateTime(2025, 12, 1, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8774), true, 3, 4, 5 },
                    { 10, new DateTime(2025, 12, 1, 13, 3, 58, 177, DateTimeKind.Local).AddTicks(8776), false, 3, 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "StudentSubjects",
                columns: new[] { "Student_Id", "Subject_Id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 4 },
                    { 3, 2 },
                    { 3, 4 },
                    { 4, 2 },
                    { 4, 5 },
                    { 5, 3 },
                    { 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_Professor_Id",
                table: "Attendances",
                column: "Professor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_Student_Id",
                table: "Attendances",
                column: "Student_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_Subject_Id",
                table: "Attendances",
                column: "Subject_Id");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_Subject_Id",
                table: "StudentSubjects",
                column: "Subject_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Professor_Id",
                table: "Subjects",
                column: "Professor_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "StudentSubjects");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Professors");
        }
    }
}
