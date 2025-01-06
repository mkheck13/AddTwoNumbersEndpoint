using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AddTwoNumbersEndpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbersController : ControllerBase
    {
        
        [HttpGet]
        [Route("Add")]

        public string addTwoNumbers(int num1, int num2)
        {
            return $"The total of {num1} and {num2} is {num1 + num2}.";
        }









    }
}