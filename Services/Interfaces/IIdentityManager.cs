using Services.CustomModels;
using Services.CustomModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IIdentityManager
    {
      
        string LoginUser(TokenRequestModel model);

        string Register(TokenRequestModel model);
      
        string EditUser(PersonModel model);
        string DeleteUser(int id);
       

    }
}
