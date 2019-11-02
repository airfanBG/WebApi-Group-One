using Services.CustomModels.Interfaces;

namespace Services.CustomModels
{
    public class RoleModel:ICustomModel
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
}
