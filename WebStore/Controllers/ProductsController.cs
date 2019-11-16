using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebStore.Models;

namespace WebStore.Controllers
{
   
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            using (HttpClient cl = new HttpClient())
            {
                var token = TempData["Token"];


                cl.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", (string)token);

                var res = cl.GetAsync("https://localhost:44330/api/products").Result;
                if (res.StatusCode!=System.Net.HttpStatusCode.Unauthorized)
                {
                    if (res != null)
                    {
                        var content = res.Content.ReadAsStringAsync();
                        var all = JsonConvert.DeserializeObject<List<ProductModel>>(content.Result);

                        return PartialView("AllProducts", all);
                    }
                    return NoContent();
                }
                return Unauthorized();
            }
          
        }
    }
}