using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using static System.Console;

namespace CoursesAndStudents
{
    public class Academy : DbContext
    {
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Student>? Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Academy;Trusted_Connection=true;MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API validation rules
            modelBuilder.Entity<Student>()
                .Property(s => s.LastName)
                .HasMaxLength(30)
                .IsRequired();

            //Populate the database with simple data
            Student alice = new()
            {
                StudentId = 1,
                FirstName = "Alice",
                LastName = "Jones"
            };

            Student bob = new()
            {
                StudentId = 2,
                FirstName = "Bob",
                LastName = "Marley"
            };

            Student cecilia = new()
            {
                StudentId = 3,
                FirstName = "Cecilia",
                LastName = "Lion"
            };

            Course csharp = new()
            {
                CourseId = 1,
                Title = "C# 10 and .NET 6"
            };

            Course webdev = new()
            {
                CourseId = 2,
                Title = "Web development"
            };

            Course python = new()
            {
                CourseId = 3,
                Title = "Python for beginners"
            };

            modelBuilder.Entity<Student>()
                .HasData(alice, bob, cecilia);

            modelBuilder.Entity<Course>()
                .HasData(csharp, webdev, python);

            modelBuilder.Entity<Course>()
                .HasData(c => c.Students)
                .WithMany(s => s.Courses)
                .UsingEntity(e => e.HasData(
                    //all students signed uo for the csharp course

                    ));
        }
    }
}
