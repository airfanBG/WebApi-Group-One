using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories.RepositoryInterfaces
{
    public interface IStoreDbContextService
    {
        DbContext Context { get; }
        public IRepository<Customer> Customers { get; }
        public IRepository<Employee> Employees { get; }
        public IRepository<Product> Products { get; }
       
        public IRepository<SaleOrder> SaleOrders { get; }
       
        void Dispose();

        int SaveChanges();
    }
}
