using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Implementations;

namespace WebStore.Controllers
{
    public class OrderController : Controller
    {
        public ProductSalesManager _manager;

        public OrderController(ProductSalesManager manager)
        {
            _manager = manager;

        }
        //public async Task<IActionResult> AddProduct(int productId, int quantity)
        //{
        //    //var res = await Task.Run(() => _manager.AddProduct(productId, quantity,1));
        //    //return View(res);
        //}
    }
}