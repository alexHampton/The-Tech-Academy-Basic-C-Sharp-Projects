using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext //SchoolContext is our DB.
    {
        public SchoolContext() : base("SchoolContext") //Specify name of the connection string. If not explicitly stated, it will take the name of the class (SchoolContext).
        {
        }

        // Each DbSet corresponds to a Table within the DB.
        public DbSet<Student> Students { get; set; } // Ex: This is Table "Student," each row consists of "Student" data, derived from the Student Class.
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); // Removes pluralizing convention of Table names.
        }
    }
}