﻿using Microsoft.EntityFrameworkCore;

namespace Employee.App.Domain
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }
    }
}
