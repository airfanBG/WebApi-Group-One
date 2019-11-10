using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;
using WebStore.Services;

namespace WebStore.Controllers
{
    public class IdentityController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            LoginService ls = new LoginService();
            var token=ls.Login(model);
          
            return View();
        }

    }
}