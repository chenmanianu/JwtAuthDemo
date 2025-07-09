using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestingController : ControllerBase
    {
        [Authorize]
        [HttpGet("secure")]
        public IActionResult GetSecureWeather()
        {
            return Ok("This is a protected endpoint!");
        }

        [AllowAnonymous]
        [HttpGet("public")]
        public IActionResult GetPublicWeather()
        {
            return Ok("This is a public endpoint.");
        }
    }
}
