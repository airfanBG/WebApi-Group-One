namespace Services.Implementations
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using Services.CustomModels;
    using Services.CustomModels.MapperSettings;
    using Services.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserRolesManager:BaseManager<UserRolesModel>
    {
        public UserRolesManager():base(new StoreDbContext())
        {
        }
       
        public ICollection<UserRolesModel> GetAll(int userId)
        {
            try
            {
              
                using (context)
                {
                    var getUser = context.UserRoles.Where(x => x.UserId == userId).Include(x=>x.Role).ToList();
                    var result = MapperConfigurator.Mapper.Map<List<UserRolesModel>>(getUser);
                    return result;
                }

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }


        public override string Add(UserRolesModel model)
        {
            try
            {
                using (context)
                {
                    User getUser = context.Users.SingleOrDefault(x => x.Id == model.Id);

                    List<Role> roles = context.Roles.Where(x => model.RoleIds.Contains(x.Id)).ToList();

                    foreach (var role in roles)
                    {
                        if (getUser.UserRoles.FirstOrDefault(x => x.RoleId == role.Id) == null)
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

        public override string Update(UserRolesModel model)
        {
            using (context)
            { 
                User user = this.context.Users.Include(x => x.UserRoles).Single(x => x.Id == model.UserId);

                List<int> newRoles = this.context.UserRoles.Where(x => x.UserId == user.Id).Select(x => x.RoleId).Where(x => model.RoleIds.Contains(x)).ToList();

                user.UserRoles.Clear();

                List<Role> getRoles = this.context.Roles.Where(x => newRoles.Contains(x.Id)).ToList();

                foreach (var role in getRoles)
                {
                    user.UserRoles.Add(new UserRoles() { Role = role });
                }
                this.context.SaveChanges();


            }
            return "";
        }

        public override string Delete(UserRolesModel model)
        {
            try
            {
                using (context)
                {
                    User getUser = context.Users.SingleOrDefault(x => x.Id == model.Id);
                    List<UserRoles> roles = context.UserRoles.Where(x => !model.RoleIds.Contains(x.Id)).ToList();
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
