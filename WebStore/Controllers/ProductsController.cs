using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebStore.Services;

namespace WebStore.Controllers
{

    public class ProductsController : Controller
    {
        private ProductService service;
        public ProductsController(ProductService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            var token = HttpContext.Session.GetString("Token");
            var res = service.All((string)token);
            if (res != null)
            {
                return PartialView("AllProducts",res);
            }
           
            return Unauthorized();            
          
        }
        
        public IActionResult GetById(int id)
        {

            var token = HttpContext.Session.GetString("Token");
            var res = service.GetById(id,token);
            if (res != null)
            {
                return Json(res);
            }

            return Unauthorized();

        }
    }
}