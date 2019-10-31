namespace Services.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using Models;
    using Services.Common;
    using Services.CustomModels;
    using Services.CustomModels.Interfaces;
    using Services.CustomModels.MapperSettings;

    public class RoleManager
    {
        private StoreDbContext context;
        public RoleManager(StoreDbContext dbContext)
        {
            this.context = dbContext;

        }

        public string Add(RoleModel model)
        {
            RoleModel roleModel = model;
            using (context)
            {
                Role role=context.Roles.FirstOrDefault(x => x.RoleName == roleModel.RoleName);
                if (role==null)
                {
                    Role newRole = new Role();
                    newRole.RoleName = roleModel.RoleName;
                    context.Roles.Add(newRole);
                    context.SaveChanges();
                    return "";
                }
                return Messages.RoleExist;
            }
        }

        public ICollection<RoleModel> GetAll()
        {
            using (context)
            {
                List<Role> list = context.Roles.ToList();
                List<RoleModel> mapped = MapperConfigurator.Mapper.Map<List<RoleModel>>(list);

                return mapped;
            }
        }

        public string Remove(RoleModel model)
        {
            using (context)
            {
                var role = MapperConfigurator.Mapper.Map<Role>(model);
                context.Roles.Remove(role);
                context.SaveChanges();
                return "";
            }
        }

        public string Update(RoleModel model)
        {
            using (context)
            {
                var role = MapperConfigurator.Mapper.Map<Role>(model);
                context.Roles.Update(role);
                context.SaveChanges();
                return "";
            }
        }
    }
}
