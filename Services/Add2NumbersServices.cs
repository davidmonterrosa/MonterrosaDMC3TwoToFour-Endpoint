using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonterrosaDMC3TwoToFour_Endpoint.Services
{
    public class Add2NumbersServices
    {
        public string AddNumbers(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return $"The sum of {firstNumber} and {secondNumber} is {sum}";
        }
    }
}