using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentT1708EWebV1.Models;

namespace StudentT1708EWebV1.Models
{
    public class StudentT1708EWebV1Context : DbContext
    {
        public StudentT1708EWebV1Context(DbContextOptions<StudentT1708EWebV1Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    RollNumber = "A002768",
                    FirstName = "Nguyen Cong",
                    Email = "nguyencong@gmail.com"
                },
                new Student()
                {
                    RollNumber = "A002238",
                    FirstName = "Duong Thu",
                    Email = "duongthu@gmail.com"
                },
                new Student()
                {
                    RollNumber = "A001568",
                    FirstName = "Ngoc Anh",
                    Email = "ngocanh@gmail.com"
                }

             );
            modelBuilder.Entity<Mark>().HasData(
                new Mark()
                {
                    Id = 1,
                    SubjectName = "Java",
                    StudentRollNumber = "A002768",
                    SubjectMark = 20
                },

                new Mark()
                {
                    Id = 2,
                    SubjectName = "C#",
                    StudentRollNumber = "A002768",
                    SubjectMark = 25
                },

                new Mark()
                {
                    Id = 3,
                    SubjectName = "Php",
                    StudentRollNumber = "A002768",
                    SubjectMark = 22
                }
                

             );

        }

        public DbSet<StudentT1708EWebV1.Models.Student> Student { get; set; }

        public DbSet<StudentT1708EWebV1.Models.Mark> Mark { get; set; }
    }
}
