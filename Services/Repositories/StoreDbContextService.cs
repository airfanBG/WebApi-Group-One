using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Interfaces;
using Services.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories
{
    public class StoreDbContextService : IStoreDbContextService
    {
        private StoreDbContext context;

        public DbContext Context { get { return this.context; } }
        private readonly Dictionary<Type, object> repositories;

        public StoreDbContextService() : this(new StoreDbContext())
        {

        }
        public StoreDbContextService(StoreDbContext dbContext)
        {
            this.context = dbContext;
            repositories = new Dictionary<Type, object>();
        }
        public IRepository<Customer> Customers
        {
            get
            {
                return this.GetRepository<Customer>();
            }
        }

        public IRepository<Employee> Employees
        {
            get
            {
                return this.GetRepository<Employee>();
            }
        }

        public IRepository<Product> Products
        {
            get
            {
                return this.GetRepository<Product>();
            }
        }

      

        public IRepository<SaleOrder> SaleOrders
        {
            get
            {
                return this.GetRepository<SaleOrder>();
            }
        }


        public void Dispose()
        {
            this.Dispose(true);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.context != null)
                {
                    this.context.Dispose();
                }
            }
        }
        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }
        private IRepository<T> GetRepository<T>() where T : class, IBaseModel, new()
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(BaseRepository<T>);

                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
