using Data;
using Services;
using Services.CustomModels;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StoreDbContext db=new StoreDbContext())
            {
                try
                {
                    //IdentityManager im = new IdentityManager();
                    //var pm = new PersonModel() { FirstName = "DD", LastName = "dd", Email = "ef@at.bg"};
                    //im.RegisterNewUser(pm);
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }
               
              
            }
        }
    }
}
