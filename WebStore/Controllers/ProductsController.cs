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
            var token = TempData["Token"];
            var res = service.All((string)token);
            if (res != null)
            {
                return PartialView("AllProducts", res);
            }
           
            return Unauthorized();            
          
        }
    }
}