using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace AdditionService.Controllers
{

    [Route("Addition-Service")]
    public class AddController : Controller
    {
        [Route("Add")]
        public IActionResult Get([FromQuery] int firstNumber, [FromQuery] int secondNumber)
        {
            return Content((firstNumber + secondNumber).ToString());
        }
    }
}
