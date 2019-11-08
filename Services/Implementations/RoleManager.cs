namespace Services.Implementations
{
    using Data;
    using Models;
    using Services.Common;
    using Services.CustomModels;
    using Services.CustomModels.MapperSettings;
    using Services.Interfaces;
    using System;
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

        public override RoleModel Get(int id)
        {
            try
            {
                using (context)
                {
                    var getRole = this.context.Customers.SingleOrDefault(x => x.Id == id);
                    var res = MapperConfigurator.Mapper.Map<RoleModel>(getRole);
                    return res;
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
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
