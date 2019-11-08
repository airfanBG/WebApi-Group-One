using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Services.CustomModels;
using Services.Implementations;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin, User, Seller")]
    public class DepartmentsController : ControllerBase
    {
        private DepartmentManager manager;

        public DepartmentsController(DepartmentManager manager)
        {
            this.manager = manager;
        }
        // GET: api/Departments
        [HttpGet]
        [Route("all")]
        [Authorize(Roles ="Admin")]
        public IActionResult GetAll()
        {
            var res = JsonConvert.SerializeObject(this.manager.AllDepartments);
            return Ok(res);
        }

        // GET: api/Departments/5
        [HttpGet("{id:int}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var res = this.manager.Get(id);
            if (res!=null)
            {
                return Ok(res);
            }
            return NotFound();
        }

        // POST: api/Departments
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Departments/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
