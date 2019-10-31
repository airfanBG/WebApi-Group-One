namespace Services.CustomModels
{
    using Services.CustomModels.Interfaces;
    using System.Collections.Generic;
    public class UserRolesModel:ICustomModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string RoleName { get; set; }
        public List<int> AddRoleIds { get; set; }
        public List<int> RemoveRolesIds { get; set; }
        public List<RoleModel> Roles { get; set; }
    }
}
