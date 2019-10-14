using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class StoreDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<SaleOrder> SalesOrders { get; set; }
        public StoreDbContext()
        {

        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=airfan\SQLEXPRESS;Database=WebApiCore;Trusted_Connection=True;");
        }

    }
}
 