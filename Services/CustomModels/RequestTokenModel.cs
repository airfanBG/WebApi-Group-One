using System.Collections.Generic;

namespace Services.CustomModels
{
    public class RequestTokenModel
    {
        public string Email { get; set; }
        public ICollection<RoleModel> Roles { get; set; }

    }
}
