namespace Services.Implementations
{
    using Services.CustomModels.Interfaces;
    using System.Collections.Generic;
    public abstract class BaseManager<T> where T:ICustomModel
    {
        public abstract string Add(ICustomModel model);
        public abstract string Remove(ICustomModel model);
        public abstract string Update(ICustomModel model);
        public abstract ICollection<ICustomModel> GetAll(int id);
    }
}
