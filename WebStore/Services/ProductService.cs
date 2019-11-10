using Services.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebStore.Services
{
    public class ProductService
    {
        private string url = "http://localhost:55542/api/Products";

        //public List<ProductModel> All()
        //{
        //    using (HttpClient cl=new HttpClient())
        //    {
        //        cl.DefaultRequestHeaders.Add("WEb app", "Hello");
           
        //        cl.GetAsync(url);
        //    }
        //}
    }
}
