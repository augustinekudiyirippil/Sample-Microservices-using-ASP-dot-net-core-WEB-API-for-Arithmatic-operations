﻿using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{

    [Route("Calculate")]
    public class ArithmaticController : Controller
    {

        [HttpGet]
        [Route("Add")]
        public IActionResult addNumbers([FromQuery] int FirstNumber, [FromQuery] int SecondNumber)
        {
            HttpClient client = new HttpClient();

            string url = string.Format("http://localhost:5272/Addition-Service/Add?firstNumber={0}&secondNumber={1}", FirstNumber, SecondNumber);


            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                return new JsonResult("The result of addition is " + response.Content.ReadAsStringAsync().Result);


            }

            else
            {
                throw new Exception("Internal server error");
            }







        }




        [HttpGet]
        [Route("Sub")]
        public IActionResult subtractNumbers([FromQuery] int SubstractFrom, [FromQuery] int NumberToSubstract)
        {
            HttpClient client = new HttpClient();

            string url = string.Format("http://localhost:5145/Subtraction-Service/Sub?firstNumber={0}&secondNumber={1}", SubstractFrom, NumberToSubstract);


            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                return new JsonResult("The result of Subtraction is " + response.Content.ReadAsStringAsync().Result);


            }

            else
            {
                throw new Exception("Internal server error");
            }

        }






        [HttpGet]
        [Route("Multiply")]
        public IActionResult multiplyNumbers([FromQuery] int FirstNumber, [FromQuery] int SecondNumber)
        {

            HttpClient client = new HttpClient();

            string url = string.Format("http://localhost:5042/Multiplication-Service/Multi?firstNumber={0}&secondNumber={1}", FirstNumber, SecondNumber);


            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                return new JsonResult("The result of multiplication is " + response.Content.ReadAsStringAsync().Result);


            }

            else
            {
                throw new Exception("Internal server error");
            }


        }


        [HttpGet]
        [Route("Division")]
        public IActionResult divideNumbers([FromQuery] int NumberToDivideFrom, [FromQuery] int DivisionNumber)
        {

            HttpClient client = new HttpClient();

            string url = string.Format("http://localhost:5064/Division-Service/Division?firstNumber={0}&secondNumber={1}", NumberToDivideFrom, DivisionNumber);


            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                return new JsonResult("The result of division is " + response.Content.ReadAsStringAsync().Result);


            }

            else
            {
                throw new Exception("Internal server error");
            }


        }




    }
}
