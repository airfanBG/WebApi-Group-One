using Microsoft.AspNetCore.Mvc;
using Services.Implementations;
using System;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsStatisticController : ControllerBase
    {
        private readonly ProductStatisticManager manager;
        public ProductsStatisticController(ProductStatisticManager manager)
        {
            this.manager = manager;
        }

        [HttpGet]
        [Route("top-selled")]
        public IActionResult GetTopSelled(DateTime from, DateTime to)
        {
            var res = manager.GetBestSelledForPeriod(from, to);
            if (res.Count > 0)
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