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
    public class UserRolesManager
    {
        private StoreDbContext context;
        public UserRolesManager(StoreDbContext dbContext)
        {
            this.context = dbContext;
           
        }
        public string Add(UserRolesModel model)
        {            
            try
            {
                UserRolesModel roleModel = model;
                using (context)
                {
                    User getUser = context.Users.SingleOrDefault(x => x.Id == roleModel.Id);
                  
                    List<Role> roles = context.Roles.Where(x => roleModel.AddRoleIds.Contains(x.Id)).ToList();

                    foreach (var role in roles)
                    {
                        if (getUser.UserRoles.FirstOrDefault(x=>x.RoleId==role.Id)==null)
                        {
                            getUser.UserRoles.Add(new UserRoles() { RoleId = role.Id, UserId = getUser.Id, Role = role, User = getUser });
                        }
                       
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

        public ICollection<UserRolesModel> GetAll(int userId)
        {
            try
            {
              
                using (context)
                {
                    var getUser = context.UserRoles.Where(x => x.UserId == userId).Include(x=>x.Role).ToList();
                    var result = MapperConfigurator.Mapper.Map<List<UserRolesModel>>(getUser);
                    return new List<UserRolesModel>();
                }

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public string Remove(UserRolesModel model)
        {
            try
            {
                UserRolesModel roleModel = model;
                using (context)
                {
                    User getUser = context.Users.SingleOrDefault(x => x.Id == roleModel.Id);
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

    }
}
