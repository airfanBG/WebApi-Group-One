namespace Services.Implementations
{
    using Data;
    using Models;
    using Services.Common;
    using Services.CustomModels;
    using Services.CustomModels.MapperSettings;
    using Services.Interfaces;
    using System.Collections.Generic;
    using System.Linq;

    public class RoleManager : BaseManager<RoleModel>
    {
        public RoleManager() : base(new StoreDbContext())
        {

        }
        public List<RoleModel> AllRoles
        {
            get
            {
                var roles = this.context.Roles.ToList();

                return MapperConfigurator.Mapper.Map<List<RoleModel>>(roles);
            }
        }
        public override string Add(RoleModel model)
        {
            RoleModel roleModel = model;
            using (context)
            {
                Role role = context.Roles.FirstOrDefault(x => x.RoleName == roleModel.RoleName);
                if (role == null)
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


        public override string Delete(RoleModel model)
        {
            using (context)
            {
                var role = MapperConfigurator.Mapper.Map<Role>(model);
                context.Roles.Remove(role);
                context.SaveChanges();
                return "";
            }
        }

        public override string Update(RoleModel model)
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
