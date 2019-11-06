namespace Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Models;
    using Models.Interfaces;
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    public class StoreDbContext : DbContext
    {
        protected IConfigurationRoot configuration;

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SaleOrder> SalesOrders { get; set; }
        public DbSet<UserToken> UserTokens { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public StoreDbContext()
        {
          
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<EmployeeCustomers>().HasOne(x => x.Employee).WithMany(x => x.EmployeeCustomers).OnDelete(DeleteBehavior.Restrict);
            // modelBuilder.Entity<EmployeeCustomers>().HasOne(x => x.Customer).WithMany(x => x.EmployeeCustomers).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().HasData(new User() { CreatedAt = DateTime.Now, Email = "dasda@das.vf", FirstName = "one", LastName = "one", Password = "1234", Id = 4 });
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, CreatedAt = DateTime.Now, ProductName = "T-shirt", CurrentQuantity = 100, Description = "Daily", ProductPrice = 10 },
                new Product() { Id = 2, CreatedAt = DateTime.Now, ProductName = "Jacket", CurrentQuantity = 50, Description = "Daily", ProductPrice = 150 },
                new Product() { Id = 3, CreatedAt = DateTime.Now, ProductName = "Shoes", CurrentQuantity = 200, Description = "Daily", ProductPrice = 125 },
                new Product() { Id = 4,CreatedAt=DateTime.Now, ProductName = "Socks", CurrentQuantity = 1000, Description = "Daily", ProductPrice = 2 });

            
            modelBuilder.Entity<Department>().HasData(
                new Department() { Id = 1, CreatedAt = DateTime.Now, DepartmentName = "Sells" },
                new Department() { Id = 2, CreatedAt = DateTime.Now, DepartmentName = "Finance" },
                new Department() { Id = 3, CreatedAt = DateTime.Now, DepartmentName = "IT" });

            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, BankAccount = 100000, EmployeeNumber = "EA0011", PersonId = 2, Telephone = "1231231",CreatedAt=DateTime.Now,DepartmentId=3 });

            modelBuilder.Entity<Role>().HasData(new Role() {Id=1, CreatedAt = DateTime.Now, RoleName = "Admin" }, new Role() {Id=2, CreatedAt = DateTime.Now, RoleName = "User" });

            modelBuilder.Entity<UserRoles>().HasData(new UserRoles() { Id = 1, CreatedAt = DateTime.Now, RoleId = 1, UserId = 2 }, new UserRoles() { Id = 2, CreatedAt = DateTime.Now, RoleId = 2, UserId = 3 });          
          

            modelBuilder.Entity<Customer>().HasData(new Customer() { Id = 1, AccountNumber = "1234", PersonId = 3 }, new Customer() { Id = 2, AccountNumber = "1234", PersonId = 4 });

            modelBuilder.Entity<SaleOrder>().HasData(
                new SaleOrder() {Id=1, CustomerId = 1, DateOfSale = DateTime.Now, Note = "", ProductId = 1, Quantity = 5 , CreatedAt = new DateTime(2019,10,10) },
                new SaleOrder() {Id=2, CustomerId = 1, DateOfSale = DateTime.Now, Note = "", ProductId = 2, Quantity = 15, CreatedAt = DateTime.Now },
                new SaleOrder() {Id=3, CustomerId = 2, DateOfSale = DateTime.Now, Note = "", ProductId = 3, Quantity = 3, CreatedAt = new DateTime(2019, 9, 12) },
                new SaleOrder() {Id=4, CustomerId = 1, DateOfSale = DateTime.Now, Note = "", ProductId = 4, Quantity = 8 , CreatedAt = new DateTime(2019, 6, 23) },
                new SaleOrder() {Id=5, CustomerId = 1, DateOfSale = DateTime.Now, Note = "", ProductId = 1, Quantity = 10, CreatedAt = new DateTime(2019, 6, 5) },
                new SaleOrder() {Id=6, CustomerId = 2, DateOfSale = DateTime.Now, Note = "", ProductId = 4, Quantity = 7, CreatedAt = new DateTime(2019, 9, 8) },
                new SaleOrder() {Id=7, CustomerId = 1, DateOfSale = DateTime.Now, Note = "", ProductId = 2, Quantity = 1 , CreatedAt = new DateTime(2019, 7, 10) },
                new SaleOrder() {Id=8, CustomerId = 2, DateOfSale = DateTime.Now, Note = "", ProductId = 2, Quantity = 11, CreatedAt = DateTime.Now });

            modelBuilder.Entity<EmployeeCustomers>().HasData(new EmployeeCustomers() {Id=1,CustomerId=1,EmployeeId=1,CreatedAt=DateTime.Now });

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            configuration = new ConfigurationBuilder().SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("DefaultConnection"));
           
        }
        public override int SaveChanges()
        {

            return this.SaveChanges(true);
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.ApplyEntityChanges();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
        private void ApplyEntityChanges()
        {
            var entries = this.ChangeTracker.Entries().Where(x => x.Entity is IAuditInfo && x.State == EntityState.Added || x.State == EntityState.Deleted || x.State == EntityState.Modified).ToList();

            foreach (var entry in entries)
            {
                var entity = (IAuditInfo)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedAt = DateTime.Now;
                }
                else if (entry.State == EntityState.Deleted)
                {
                    entity.DeletedAt = DateTime.Now;

                }
                else
                {
                    entity.ModifiedAt = DateTime.Now;
                }
            }
        }

    }
}
