using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Services
{
    public class LoginService
    {
        private string url = "http://localhost:55542/api/users/login";

        public string Login(LoginModel model)
        {
            using (HttpClient cl=new HttpClient())
            {
                var content = JsonConvert.SerializeObject(model);
                var buffer = Encoding.UTF8.GetBytes(content);
                var bytes = new ByteArrayContent(buffer);
                bytes.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var res=cl.PostAsync(url, bytes).Result;
                
                var token = res.Content.ReadAsStringAsync().Result;

                return token;
            }

            
        }
    }
}
