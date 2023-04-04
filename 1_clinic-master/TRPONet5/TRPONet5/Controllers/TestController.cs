using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace TRPONet5.Controllers
{

    public class TestController : Controller
    {
        [HttpGet("0api/user")]
        public IActionResult Get() 
        {
            return Ok(new { name = "Nick" });
        }
    }
}
