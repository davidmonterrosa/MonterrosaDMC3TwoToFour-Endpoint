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
    public class GreaterThanOrLessThanController : ControllerBase
    {
        private readonly GreaterThanOrLessThanServices _greaterThanOrLessThanServices;

        public GreaterThanOrLessThanController(GreaterThanOrLessThanServices greaterThanOrLessThanServices)
        {
            _greaterThanOrLessThanServices = greaterThanOrLessThanServices;
        }

        [HttpGet]
        [Route("CompareNumbers/{firstNumber}/{secondNumber}")]

        public string CompareNumbers(int firstNumber, int secondNumber)
        {
            return _greaterThanOrLessThanServices.CompareNumbers(firstNumber, secondNumber);
        }
    }
}