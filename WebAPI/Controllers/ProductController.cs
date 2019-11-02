using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.CustomModels;
using Services.Implementations;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ProductController : ControllerBase
    {
        private ProductManager manager;
        public ProductController(ProductManager productManager)
        {
            this.manager = productManager;
        }

        [HttpGet]
        public IActionResult AllProducts()
        {
            var all = manager.AllProducts;
            return Ok(all);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductModel model)
        {
            var res=manager.Add(model);
            if (res.Length==0)
            {
                return Created("api/product", model);
            }
            return BadRequest();
        }
    }
}