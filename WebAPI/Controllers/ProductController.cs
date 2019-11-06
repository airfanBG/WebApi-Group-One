namespace WebAPI.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using Services.CustomModels;
    using Services.Implementations;

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin, User")]
    public class ProductsController : ControllerBase
    {
        private ProductManager manager;
        public ProductsController(ProductManager productManager)
        {
            this.manager = productManager;
        }

        [HttpGet]
        public IActionResult AllProducts()
        {
            var all = manager.AllProducts;
            var res = JsonConvert.SerializeObject(all);
            return Ok(res);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddProduct([FromForm]ProductModel model)
        {

            var res = manager.Add(model);
            if (res.Length == 0)
            {
                return Created("api/products", model);
            }
            return BadRequest();
        }
        [HttpDelete]
        [Route("delete")]
        public IActionResult DeleteProduct(int id)
        {
            var res=manager.Delete(id);
            if (res.Length!=0)
            {
                return BadRequest();
            }
            return NoContent();
        }
    } 
}