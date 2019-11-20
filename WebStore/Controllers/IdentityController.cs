using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
                HttpContext.Session.SetString("Token",token.Value);
                

                return Redirect("../Products/index");
            }
           
        }

    }
}