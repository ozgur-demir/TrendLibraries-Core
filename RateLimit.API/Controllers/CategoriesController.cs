using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RateLimit.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok(new { Id = 1, Name = "Items"});
        }
        [HttpPost]
        public IActionResult SaveProduct()
        {
            return Ok(new { Status = "Success" });
        }
    }
}
