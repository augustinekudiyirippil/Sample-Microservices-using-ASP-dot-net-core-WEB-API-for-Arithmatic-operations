using Microsoft.AspNetCore.Mvc;

namespace DivisionService.Controllers
{
    public class DivisionController : Controller
    {
        [Route("Division-Service")]
        public class SubController : Controller
        {
            [Route("Division")]
            public IActionResult Get([FromQuery] int firstNumber, [FromQuery] int secondNumber)
            {
                return Content((firstNumber / secondNumber).ToString());
            }

        }
    }
}
