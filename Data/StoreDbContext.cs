using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Data
{
    public class StoreDbContext:DbContext
    {
        protected IConfigurationRoot configuration;

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<SaleOrder> SalesOrders { get; set; }
        public StoreDbContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeCustomers>().HasOne(x => x.Employee).WithMany(x => x.EmployeeCustomers).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EmployeeCustomers>().HasOne(x => x.Customer).WithMany(x => x.EmployeeCustomers).OnDelete(DeleteBehavior.Restrict);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            configuration = new ConfigurationBuilder().SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("DefaultConnection"));          
        }

    }
}
