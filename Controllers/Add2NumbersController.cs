using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonterrosaDMC3TwoToFour_Endpoint.Services;

namespace MonterrosaDMC3TwoToFour_Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Add2NumbersController : ControllerBase
    {
        private readonly Add2NumbersServices _add2NumbersServices;
        
        public Add2NumbersController(Add2NumbersServices add2NumbersServices)
        {
            _add2NumbersServices = add2NumbersServices;
        }

        [HttpGet]
        [Route("Add/{firstNumber}/{secondNumber}")]

        public string AddNumbers(int firstNumber, int secondNumber)
        {
           return _add2NumbersServices.AddNumbers(firstNumber, secondNumber);
        }

    }
}