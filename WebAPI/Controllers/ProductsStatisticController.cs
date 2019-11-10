using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Implementations;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsStatisticController : ControllerBase
    {
        private ProductStatisticManager manager;
        public ProductsStatisticController(ProductStatisticManager manager)
        {
            this.manager = manager;
        }

        [HttpGet]
        [Route("top-selled")]
        public IActionResult GetTopSelled(DateTime from,DateTime to)
        {
            var res = manager.GetBestSelledForPeriod(from, to);
            if (res.Count>0)
            {
                return Ok(res);
            }
            return NoContent();
        }
        [HttpGet]
        [Route("get-revenues")]
        public IActionResult GetRevenues(DateTime from, DateTime to)
        {
            var res = manager.GetRevenuesByPeriod(from, to);

            return Ok(res);
        }
    }
}