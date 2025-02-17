using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace C43_G02_EF04.Data.Models
{
    internal class CompanyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Comp;Trusted_Connection=True;MultipleActiveResultSets=true;trustservercertificate=true");
            optionsBuilder.UseLazyLoadingProxies(); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>()
                 .HasKey(sc => new { sc.stud_ID,sc.Course_ID});

            #region TPH
            //modelBuilder.Entity<FullTimeEmployee>()
            //    .HasBaseType<Employee>();


            //modelBuilder.Entity<PartTimeEmployee>()
            //   .HasBaseType<Employee>();
            #endregion

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<FullTimeEmployee> Full_Time_Employees { get; set; }
        public DbSet<PartTimeEmployee> Part_Time_Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Studient> Studients { get; set; }
   public DbSet<Stud_Course> Stud_Course { get; set; }
  



    }
}
