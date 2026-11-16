using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Infrastructure.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
            
        }

        public DbSet<Department> departments { get; set; }

        public DbSet<Student> students { get; set; }

        public DbSet<DepartmentSubject> departmentSubjects { get; set; }

        public DbSet<Subject> subjects { get; set; }

        public DbSet<StudentSubject> studentSubjects { get; set; }
    }
}
