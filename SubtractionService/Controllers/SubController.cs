using Microsoft.AspNetCore.Mvc;

namespace SubtractionService.Controllers
{

    [Route("Subtraction-Service")]
    public class SubController : Controller
    {
        [Route("Sub")]
        public IActionResult Get([FromQuery] int firstNumber, [FromQuery] int secondNumber)
        {
            return Content((firstNumber - secondNumber).ToString());
        }

    }
}
