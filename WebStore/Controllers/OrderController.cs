using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.CustomModels;
using Services.Implementations;

namespace WebStore.Controllers
{
    
    public class OrderController : Controller
    {
        public ProductSalesManager _manager;
        private List<ProductSaleOrderModel> _orders;
        public OrderController(ProductSalesManager manager)
        {
            _manager = manager;
            _orders = new List<ProductSaleOrderModel>();
        }
        public IActionResult AddProduct(int productId, int quantity)
        {
            if (ModelState.IsValid)
            {
                _orders.Add(new ProductSaleOrderModel() {ProductId=productId,Quantity=quantity });
                return View();
            }
            return View();
        }
        public IActionResult MakeOrder(ProductSaleOrderModel model)
        {
            if (ModelState.IsValid)
            {
                var res = _manager.SaleProduct(model);
                if (string.IsNullOrEmpty(res))
                {
                    return Ok();

                }
                return View(res);
            }
            return View();
        }
    }
}