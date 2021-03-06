﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.CustomModels;
using Services.Implementations;
using X.PagedList;

namespace WebStore.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private ProductManager _manager;
        private int pageSize=20;
        public ProductController(ProductManager manager)
        {
            _manager = manager;
        }
        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var res = _manager.AllProducts.ToPagedList(pageNumber,pageSize);
            return PartialView("_ProductsList",res);
        }
        
        public IActionResult AddProduct()
        {
            return View();
        }
       
        public IActionResult Save(ProductModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}