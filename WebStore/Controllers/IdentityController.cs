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
            if (token.Key=="Error")
            {
                return Unauthorized(token.Value);
            }
            else
            {
                if (!TempData.Keys.Contains("Token"))
                {
                    TempData.Add(new KeyValuePair<string, object>("Token", token.Value));
                }
                else
                {
                    TempData["Token"] = token;
                }

                return Redirect("../Products/index");
            }
           
        }

    }
}