using Microsoft.EntityFrameworkCore;
using Models.Interfaces;
using System;
using System.Linq;

namespace Services.Repositories.RepositoryInterfaces
{
    public interface IRepository<T> where T : class, IBaseModel
    {
        DbContext Context { get; set; }
        DbSet<T> DbSet { get; set; }
        IQueryable<T> All(Func<T, bool> func = null);

        T GetById(int id);
        T GetByEntity(T entity);
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(object id);
        int SaveChanges();

    }
}
