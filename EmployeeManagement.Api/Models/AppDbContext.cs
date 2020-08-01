using EmployeeManagement.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Seed department data
            modelBuilder.Entity<Department>().HasData(
                new Department() { DepartmentId = 1, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department() { DepartmentId = 2, DepartmentName = "SOFTWARE" });
            modelBuilder.Entity<Department>().HasData(
                new Department() { DepartmentId = 3, DepartmentName = "BUSINESS" });
            modelBuilder.Entity<Department>().HasData(
                new Department() { DepartmentId = 4, DepartmentName = "OPERATIONS" });
            //Seed employees data
            modelBuilder.Entity<Employee>().HasData(
                new Employee() 
                {
                    FirstName = "Ude",
                    DOB = new DateTime(1950, 3, 12),
                    DepartmentId = 1,
                    Email = "john@gmail.com",
                    EmployeeId = 1,
                    Gender = Gender.Male,
                    LastName = "John",
                    Passport = "Images/team1.jpg"
                });
            modelBuilder.Entity<Employee>().HasData(
               new Employee()
               {
                   FirstName = "Ude",
                   DOB = new DateTime(1950, 3, 12),
                   DepartmentId = 1,
                   Email = "john@gmail.com",
                   EmployeeId = 2,
                   Gender = Gender.Male,
                   LastName = "John",
                   Passport = "Images/team1.jpg"
               });
            modelBuilder.Entity<Employee>().HasData(
               new Employee()
               {
                   
                   FirstName = "Eze",
                   DOB = new DateTime(1960, 3, 12),
                   DepartmentId = 2,
                   Email = "Jane@gmail.com",
                   EmployeeId = 3,
                   Gender = Gender.Female,
                   LastName = "Jane",
                   Passport = "Images/team3.jpg"
               });
        }
    }
}
