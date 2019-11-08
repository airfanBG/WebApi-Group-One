namespace WebAPI.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Services.Common;
    using Services.CustomModels;
    using Services.Interfaces;

    [Route("api/users")]
    [ApiController]
    
    public class UsersController : ControllerBase
    {
        private readonly IIdentityManager manager;

        public UsersController(IIdentityManager manager)
        {
            this.manager = manager;
        }

        [HttpPost]
        public IActionResult RegisterUser([FromBody] RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var result = manager.Register(model);
                if (result.Length > 0)
                {
                    return Ok(result);
                }
                return BadRequest("Register attempt is failed. Check email and password!");
            }
            return BadRequest(ModelInfo.TurnModelToString(model));
        }
        
        [HttpDelete]
        [Authorize(Roles="Admin")]
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
        [Authorize(Roles ="Admin")]
        public IActionResult EditUser([FromBody]PersonModel model)
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
        public IActionResult Login([FromBody] LoginModel request)
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