namespace Services.CustomModels
{
    using Services.CustomModels.Interfaces;
    using System.Collections.Generic;
    public class UserRolesModel : ICustomModel
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public List<string> RoleIds { get; set; }

        public List<RoleModel> Roles { get; set; }
    }
}
