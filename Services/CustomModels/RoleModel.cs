namespace Services.CustomModels
{
    using Services.CustomModels.Interfaces;

    public class RoleModel : ICustomModel
    {
        public string Id { get; set; }
        public string RoleName { get; set; }
    }
}
