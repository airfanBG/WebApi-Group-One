using Data;
using Services.CustomModels.Interfaces;

namespace Services.Interfaces
{

    public abstract class BaseManager<T> where T : ICustomModel
    {
        protected StoreDbContext context;
        public BaseManager(StoreDbContext db)
        {
            this.context = db;
        }
        public abstract string Add(T model);
        public abstract string Update(T model);
        public abstract string Delete(T model);
        public abstract T Get(string id);
    }
}
