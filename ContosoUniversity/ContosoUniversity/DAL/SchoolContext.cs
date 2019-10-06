using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ContosoUniversity.DAL
{
    //The main class that coordinates Entity Framework functionality for a given data model is the database context class
    //(deriving from the System.Data.Entity.DbContext class). In your code, you specify which entities are included in the data model.
    public class SchoolContext : DbContext
    {
        //The name of the connection string is passed in to the constructor.
        public SchoolContext() : base("SchoolContext")
        {
        }

        //This code creates a DbSet property for each entity set.
        //In Entity Framework terminology, an entity set typically corresponds to a database table, and an entity corresponds to a row in the table.
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //prevents table names from being pluralized. Developers disagree about whether table names should be pluralized or not.
            //This tutorial uses the singular form, but the important point is that you can select whichever form you prefer by including or omitting this line of code.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}