using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Common;
using Services.CustomModels;
using Services.CustomModels.Interfaces;
using Services.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IIdentityManager manager;

        public UsersController(IIdentityManager manager)
        {
            this.manager = manager;
        }
       
        [HttpPost]
        public IActionResult RegisterUser([FromBody] TokenRequestModel model)
        {
            if (ModelState.IsValid)
            {
                var result = manager.Register(model);
                return Ok(result);
            }
            return BadRequest(ModelInfo.TurnModelToString(model));
        }
        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            var res = manager.DeleteUser(id);
            if (res.Length == 0)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPut]
        public IActionResult EditUser(PersonModel model)
        {
            var res = manager.EditUser(model);
            if (res.Length == 0)
            {
                return Ok(model);
            }
            return BadRequest();
        }
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] TokenRequestModel request)
        {
            var res = manager.LoginUser(request);
            if (res.Length > 0)
            {
                return Ok(res);
            }
            return Unauthorized();
        }
    }
}