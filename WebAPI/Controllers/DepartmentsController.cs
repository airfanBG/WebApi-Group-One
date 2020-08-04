using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Services.CustomModels;
using Services.Implementations;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin, User, Seller")]
    public class DepartmentsController : ControllerBase
    {
        private readonly DepartmentManager manager;

        public DepartmentsController(DepartmentManager manager)
        {
            this.manager = manager;
        }
        // GET: api/Departments
        [HttpGet]
        [Route("all")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAll()
        {
            var res = this.manager.AllDepartments;
            return Ok(res);
        }

        // GET: api/Departments/5
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var res = this.manager.Get(id);
            if (res != null)
            {
                return Ok(res);
            }
            return NotFound();
        }

        // POST: api/Departments
        [HttpPost]
        public IActionResult Post([FromBody] DepartmentModel model)
        {
            var res = this.manager.Add(model);
            if (res.Length == 0)
            {
                return Created("api/Departments", model);
            }
            return BadRequest(res);
        }


        [HttpPut]
        public IActionResult Put([FromBody] DepartmentModel model)
        {
            var res = this.manager.Update(model);
            if (res.Length == 0)
            {
                return Created("api/Departments", model);
            }
            return BadRequest(res);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var res = this.manager.Delete(id);
            if (res.Length == 0)
            {
                return Ok();
            }
            return BadRequest(res);
        }
    }
}
