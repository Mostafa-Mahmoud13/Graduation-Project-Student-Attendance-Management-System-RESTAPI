using Final_Project.Model;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options): base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var Students = new List<Student>()
            {
                new Student { Student_id = 1, St_Name = "Mostafa", Email = "mostafa@gmail.com", Password = "123456", Phone = 1234567894,
                     Department = "CS",St_code = 111,Gender = "Male" },
                new Student{Student_id = 2,St_Name = "Sara", Email = "sara@gmail.com",Password = "abcdef", Phone = 1098765432,
                     Department = "IT", St_code = 112,Gender = "Female"},
                new Student{Student_id = 3,St_Name = "Youssef", Email = "youssef@gmail.com",Password = "pass123",Phone = 1112223335,
                     Department = "CS",St_code = 113,Gender = "Male" },
                new Student{Student_id = 4,St_Name = "Nada",Email = "nada@gmail.com",Password = "nada321",  Phone = 1244555666,
                     Department = "IS",St_code = 114,Gender = "Female" },
                new Student{Student_id = 5,St_Name = "Ahmed",Email = "ahmed@gmail.com",Password = "omar789",  Phone = 1577888999,
                     Department = "CS",St_code = 115,Gender = "Male"},
                new Student{Student_id = 6,St_Name = "Omar", Email = "omar@gmail.com",Password = "omar123", Phone = 1222333444,
                     Department = "IT",St_code = 116,Gender = "Male"},
                new Student{Student_id = 7,St_Name = "Mariam", Email = "mariam@gmail.com",Password = "mariam123", Phone = 1333444555,
                    Department = "CS",St_code = 117,Gender = "Female"},
                new Student{Student_id = 8,St_Name = "Khaled", Email = "khaled@gmail.com",Password = "khaled123",Phone = 1444555666,
                    Department = "IS",St_code = 118,Gender = "Male"},
                new Student{Student_id = 9,St_Name = "Hana", Email = "hana@gmail.com",Password = "hana123",Phone = 1555666777,
                    Department = "CS",St_code = 119,Gender = "Female"},
                new Student{Student_id = 10,St_Name = "Mahmoud", Email = "mahmoud@gmail.com",Password = "mahmoud123",Phone = 1666777888,
                    Department = "IT",St_code = 120,Gender = "Male"},
                new Student{Student_id = 11,St_Name = "Ali", Email = "ali@gmail.com",Password = "ali123",Phone = 1777888999,
                    Department = "CS",St_code = 121,Gender = "Male"},
                new Student{Student_id = 12,St_Name = "Fatma", Email = "fatma@gmail.com",Password = "fatma123",Phone = 1888999000,
                   Department = "IT",St_code = 122,Gender = "Female"},
                new Student{Student_id = 13,St_Name = "Ibrahim", Email = "ibrahim@gmail.com",Password = "ibrahim123",Phone = 1999000111,
                    Department = "IS",St_code = 123,Gender = "Male"},
                new Student{Student_id = 14,St_Name = "Nour", Email = "nour@gmail.com",Password = "nour123",Phone = 2000111222,
                    Department = "CS",St_code = 124,Gender = "Female"},
                new Student{Student_id = 15,St_Name = "Yara", Email = "yara@gmail.com",Password = "yara123",Phone = 2111222333,
                    Department = "IT",St_code = 125,Gender = "Female"},
                new Student{Student_id = 16,St_Name = "Amr", Email = "amr@gmail.com",Password = "amr123",Phone = 2222333444,
                    Department = "CS",St_code = 126,Gender = "Male"},
                new Student{Student_id = 17,St_Name = "Salem", Email = "salem@gmail.com",Password = "salem123",Phone = 2333444555,
                    Department = "IS",St_code = 127,Gender = "Male"},
                new Student{Student_id = 18,St_Name = "Laila", Email = "laila@gmail.com",Password = "laila123",Phone = 2444555666,
                    Department = "CS",St_code = 128,Gender = "Female"},
                new Student{Student_id = 19,St_Name = "Karim", Email = "karim@gmail.com",Password = "karim123",Phone = 2555666777,
                    Department = "IT",St_code = 129,Gender = "Male"},
                new Student{Student_id = 20,St_Name = "Hossam", Email = "hossam@gmail.com",Password = "hossam123",Phone = 2666777888,
                    Department = "CS",St_code = 130,Gender = "Male"}
            };

            var Professors = new List<Professor>()
            {
                new Professor{Professor_id = 1,Pro_Name = "Dr. Ahmed",Pro_code = 201,Gender = "Male",Department = "CS",
                    Email = "ahmed@gmail.com",Password = "pass123",Phone = 1253456789},
                new Professor{Professor_id = 2,Pro_Name = "Dr. Mona",Pro_code = 202,Gender = "Female",Department = "IT",
                    Email = "mona@gmail.com",Password = "mona321",Phone = 1287654321},
                new Professor{Professor_id = 3,Pro_Name = "Dr. Tarek",Pro_code = 203,Gender = "Male",Department = "IS",
                    Email = "tarek@gmail.com",Password = "tarek456",Phone = 1171222333},
                new Professor{Professor_id = 4,Pro_Name = "Dr. Salma",Pro_code = 204,Gender = "Female",Department = "CS",
                    Email = "salma@gmail.com",Password = "salma789",Phone = 1284555666},
                new Professor{Professor_id = 5,Pro_Name = "Dr. Mostafa",Pro_code = 205,Gender = "Male",Department = "IT",
                    Email = "mostafa@gmail.com",Password = "mostafa000",Phone = 1077888999},
                new Professor{Professor_id = 6,Pro_Name = "Dr. Lina",Pro_code = 206,Gender = "Female",Department = "CS",
                    Email = "lina@gmail.com",Password = "lina123",Phone = 222333444},
                new Professor{Professor_id = 7,Pro_Name = "Dr. Hassan",Pro_code = 207,Gender = "Male",Department = "CS",
                    Email = "hassan@gmail.com",Password = "hassan123",Phone = 2333333333},
                new Professor{Professor_id = 8,Pro_Name = "Dr. Rania",Pro_code = 208,Gender = "Female",Department = "IT",
                    Email = "rania@gmail.com",Password = "rania123",Phone = 2444444444},
                new Professor{Professor_id = 9,Pro_Name = "Dr. Khaled",Pro_code = 209,Gender = "Male",Department = "IS",
                    Email = "khaled@gmail.com",Password = "khaled123",Phone = 2555555555}
                            };
            var Subjects = new List<Subject>()
            {
                new Subject { Sub_ID = 1, Sub_Name = "OOP", Sub_Code = "CS101", Professor_Id = 1 },
                new Subject { Sub_ID = 2, Sub_Name = "Databases", Sub_Code = "CS102", Professor_Id = 4 },
                new Subject { Sub_ID = 3, Sub_Name = "Networks", Sub_Code = "IT201", Professor_Id = 2 },
                new Subject { Sub_ID = 4, Sub_Name = "Algorithms", Sub_Code = "CS202", Professor_Id = 6 },
                new Subject { Sub_ID = 5, Sub_Name = "Information Security", Sub_Code = "IS301", Professor_Id = 3 },
                new Subject { Sub_ID = 6, Sub_Name = "Operating Systems", Sub_Code = "CS303", Professor_Id = 1 },
                new Subject { Sub_ID = 7, Sub_Name = "Artificial Intelligence", Sub_Code = "CS404", Professor_Id = 6 },
                new Subject { Sub_ID = 8, Sub_Name = "Web Development", Sub_Code = "IT305", Professor_Id = 2 },
                new Subject { Sub_ID = 9, Sub_Name = "Machine Learning", Sub_Code = "CS405", Professor_Id = 7 },
                new Subject { Sub_ID = 10, Sub_Name = "Cloud Computing", Sub_Code = "IT402", Professor_Id = 8 },
                new Subject { Sub_ID = 11, Sub_Name = "Cyber Security", Sub_Code = "IS404", Professor_Id = 9 },
                new Subject { Sub_ID = 12, Sub_Name = "Software Engineering", Sub_Code = "CS350", Professor_Id = 7 }
            };
            var Attendances = new List<Attendance>()
            {
                new Attendance { Id = 1, Student_Id = 1, Subject_Id = 1, Professor_Id = 1, Date = DateTime.Now.AddDays(-2), Present = true },
                new Attendance { Id = 2, Student_Id = 2, Subject_Id = 1, Professor_Id = 1, Date = DateTime.Now.AddDays(-2), Present = false },
                new Attendance { Id = 3, Student_Id = 3, Subject_Id = 2, Professor_Id = 4, Date = DateTime.Now.AddDays(-1), Present = true },
                new Attendance { Id = 4, Student_Id = 4, Subject_Id = 2, Professor_Id = 4, Date = DateTime.Now.AddDays(-1), Present = true },
                new Attendance { Id = 5, Student_Id = 5, Subject_Id = 3, Professor_Id = 2, Date = DateTime.Now.AddDays(-3), Present = false },
                new Attendance { Id = 6, Student_Id = 1, Subject_Id = 3, Professor_Id = 2, Date = DateTime.Now.AddDays(-3), Present = true },
                new Attendance { Id = 7, Student_Id = 2, Subject_Id = 4, Professor_Id = 6, Date = DateTime.Now.AddDays(-4), Present = true },
                new Attendance { Id = 8, Student_Id = 3, Subject_Id = 4, Professor_Id = 6, Date = DateTime.Now.AddDays(-4), Present = false },
                new Attendance { Id = 9, Student_Id = 4, Subject_Id = 5, Professor_Id = 3, Date = DateTime.Now.AddDays(-5), Present = true },
                new Attendance { Id = 10, Student_Id = 5, Subject_Id = 5, Professor_Id = 3, Date = DateTime.Now.AddDays(-5), Present = false },
                new Attendance { Id = 11, Student_Id = 6, Subject_Id = 6, Professor_Id = 1, Date = DateTime.Now.AddDays(-1), Present = true },
                new Attendance { Id = 12, Student_Id = 7, Subject_Id = 7, Professor_Id = 6, Date = DateTime.Now.AddDays(-2), Present = false },
                new Attendance { Id = 13, Student_Id = 8, Subject_Id = 5, Professor_Id = 3, Date = DateTime.Now.AddDays(-3), Present = true },
                new Attendance { Id = 14, Student_Id = 9, Subject_Id = 2, Professor_Id = 4, Date = DateTime.Now.AddDays(-4), Present = true },
                new Attendance { Id = 15, Student_Id = 10, Subject_Id = 8, Professor_Id = 2, Date = DateTime.Now.AddDays(-2), Present = false },
                new Attendance { Id = 16, Student_Id = 11, Subject_Id = 9, Professor_Id = 7, Date = DateTime.Now.AddDays(-1), Present = true },
                new Attendance { Id = 17, Student_Id = 12, Subject_Id = 10, Professor_Id = 8, Date = DateTime.Now.AddDays(-2), Present = false },
                new Attendance { Id = 18, Student_Id = 13, Subject_Id = 11, Professor_Id = 9, Date = DateTime.Now.AddDays(-3), Present = true },
                new Attendance { Id = 19, Student_Id = 14, Subject_Id = 12, Professor_Id = 7, Date = DateTime.Now.AddDays(-1), Present = true },
                new Attendance { Id = 20, Student_Id = 15, Subject_Id = 9, Professor_Id = 7, Date = DateTime.Now.AddDays(-2), Present = false },
                new Attendance { Id = 21, Student_Id = 16, Subject_Id = 10, Professor_Id = 8, Date = DateTime.Now.AddDays(-3), Present = true },
                new Attendance { Id = 22, Student_Id = 17, Subject_Id = 11, Professor_Id = 9, Date = DateTime.Now.AddDays(-1), Present = true },
                new Attendance { Id = 23, Student_Id = 18, Subject_Id = 12, Professor_Id = 7, Date = DateTime.Now.AddDays(-2), Present = false },
                new Attendance { Id = 24, Student_Id = 19, Subject_Id = 9, Professor_Id = 7, Date = DateTime.Now.AddDays(-3), Present = true },
                new Attendance { Id = 25, Student_Id = 20, Subject_Id = 10, Professor_Id = 8, Date = DateTime.Now.AddDays(-1), Present = true }

            };
            var StudentSubjects = new List<StudentSubject>()
            {
                new StudentSubject { Student_Id = 1, Subject_Id = 1 },
                new StudentSubject { Student_Id = 1, Subject_Id = 3 },
                new StudentSubject { Student_Id = 2, Subject_Id = 1 },
                new StudentSubject { Student_Id = 2, Subject_Id = 4 },
                new StudentSubject { Student_Id = 3, Subject_Id = 2 },
                new StudentSubject { Student_Id = 3, Subject_Id = 4 },
                new StudentSubject { Student_Id = 4, Subject_Id = 2 },
                new StudentSubject { Student_Id = 4, Subject_Id = 5 },
                new StudentSubject { Student_Id = 5, Subject_Id = 3 },
                new StudentSubject { Student_Id = 5, Subject_Id = 5 },
                new StudentSubject { Student_Id = 11, Subject_Id = 9 },
                new StudentSubject { Student_Id = 12, Subject_Id = 10 },
                new StudentSubject { Student_Id = 13, Subject_Id = 11 },
                new StudentSubject { Student_Id = 14, Subject_Id = 12 },
                new StudentSubject { Student_Id = 15, Subject_Id = 9 },
                new StudentSubject { Student_Id = 16, Subject_Id = 10 },
                new StudentSubject { Student_Id = 17, Subject_Id = 11 },
                new StudentSubject { Student_Id = 18, Subject_Id = 12 },
                new StudentSubject { Student_Id = 19, Subject_Id = 9 },
                new StudentSubject { Student_Id = 20, Subject_Id = 10 }
            };



            modelBuilder.Entity<Student>().HasData(Students);
            modelBuilder.Entity<Professor>().HasData(Professors);
            modelBuilder.Entity<Subject>().HasData(Subjects);
            modelBuilder.Entity<Attendance>().HasData(Attendances);
            modelBuilder.Entity<StudentSubject>().HasData(StudentSubjects);

            // علاقة Subject ↔ Professor
            modelBuilder.Entity<Subject>()
                .HasOne(s => s.Professor)
                .WithMany(p => p.Subjects)
                .HasForeignKey(s => s.Professor_Id);

            // علاقة Attendance ↔ Student
            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.Student)
                .WithMany(s => s.Attendances)
                .HasForeignKey(a => a.Student_Id);

            // علاقة Attendance ↔ Subject
            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.Subject)
                .WithMany(s => s.Attendances)
                .HasForeignKey(a => a.Subject_Id);

            // علاقة Attendance ↔ Professor
            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.Professor)
                .WithMany(p => p.Attendances)
                .HasForeignKey(a => a.Professor_Id);

            // === Many-to-Many بين Student و Subject عن طريق StudentSubject ===
            modelBuilder.Entity<StudentSubject>()
                .HasKey(ss => new { ss.Student_Id, ss.Subject_Id });

            modelBuilder.Entity<StudentSubject>()
                .HasOne(ss => ss.Student)
                .WithMany(s => s.StudentSubjects)
                .HasForeignKey(ss => ss.Student_Id);

            modelBuilder.Entity<StudentSubject>()
                .HasOne(ss => ss.Subject)
                .WithMany(s => s.StudentSubjects)
                .HasForeignKey(ss => ss.Subject_Id);


            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Professor> Professors { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<StudentSubject> StudentSubjects { get; set; }


    }
}
