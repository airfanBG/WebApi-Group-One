using Services.CustomModels;

namespace Services.Interfaces
{
    public interface IIdentityManager
    {

        string LoginUser(LoginModel model);

        string Register(RegisterModel model);

        string EditUser(PersonModel model);
        string DeleteUser(string id);


    }
}
