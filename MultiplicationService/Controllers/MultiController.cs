using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MultiplicationService.Controllers
{
    [Route("Multiplication-Service")]
    public class SubController : Controller
    {
        [Route("Multi")]
        public IActionResult Get([FromQuery] int firstNumber, [FromQuery] int secondNumber)
        {
            return Content((firstNumber * secondNumber).ToString());
        }

    }
}
