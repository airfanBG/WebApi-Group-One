
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Services
{
    public class ProductService
    {
         private string url = "https://localhost:44330/api/products";

        public List<ProductModel> All(string token)
        {
            using (HttpClient cl = new HttpClient())
            {
                cl.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",token);

                var res = cl.GetAsync(url).Result;
                if (res.StatusCode != System.Net.HttpStatusCode.Unauthorized)
                {
                        var content = res.Content.ReadAsStringAsync();
                        var all = JsonConvert.DeserializeObject<List<ProductModel>>(content.Result);
                        return  all;                      
                }
                return null;
            }
        }
    }
}
