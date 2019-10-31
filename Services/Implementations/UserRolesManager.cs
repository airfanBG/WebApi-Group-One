using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using Services.CustomModels;
using Services.CustomModels.Interfaces;
using Services.CustomModels.MapperSettings;
using Services.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Implementations
{
    public class UserRolesManager<T>:BaseManager<T> where T:UserRolesModel
    {
        private StoreDbContext context;
        public UserRolesManager(StoreDbContext dbContext)
        {
            this.context = dbContext;
           
        }
        public override string Add(ICustomModel model)
        {            
            try
            {
                UserRolesModel roleModel = model as UserRolesModel;
                using (context)
                {
                    User getUser = context.Users.SingleOrDefault(x => x.Id == roleModel.UserId);
                  
                    List<Role> roles = context.Roles.Where(x => roleModel.AddRoleIds.Contains(x.Id)).ToList();

                    foreach (var role in roles)
                    {
                        getUser.UserRoles.Add(new UserRoles() { RoleId = role.Id, UserId = getUser.Id, Role = role, User = getUser });
                    }

                    context.Users.Update(getUser);
                    context.SaveChanges();
                    return "";
                }

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public override ICollection<ICustomModel> GetAll(int id)
        {
            try
            {
              
                using (context)
                {
                    var getUser = context.UserRoles.Where(x => x.UserId == id).Include(x=>x.Role).ToList();
                    var result = MapperConfigurator.Mapper.Map<List<UserRolesModel>>(getUser);
                    return new List<ICustomModel>();
                }

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public override string Remove(ICustomModel model)
        {
            try
            {
                UserRolesModel roleModel = model as UserRolesModel;
                using (context)
                {
                    User getUser = context.Users.SingleOrDefault(x => x.Id == roleModel.UserId);
                    List<UserRoles> roles = context.UserRoles.Where(x => roleModel.RemoveRolesIds.Contains(x.Id)).ToList();
                    foreach (var role in roles)
                    {
                        getUser.UserRoles.Remove(role);
                    }
                    context.Users.Update(getUser);
                    context.SaveChanges();
                    return "";
                }

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public override string Update(ICustomModel model)
        {
            throw new NotImplementedException();
        }
    }
}
