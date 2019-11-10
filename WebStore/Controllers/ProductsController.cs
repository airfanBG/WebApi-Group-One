﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}