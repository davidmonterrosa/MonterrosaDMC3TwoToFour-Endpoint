using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonterrosaDMC3TwoToFour_Endpoint.Services
{
    public class GreaterThanOrLessThanServices
    {
        public string CompareNumbers(int firstNumber, int secondNumber)
        {
            if(firstNumber > secondNumber) {
                return $"{firstNumber} is greater than {secondNumber}.\n{secondNumber} is less than {firstNumber}.";
            } else if(firstNumber < secondNumber) {
                return $"{firstNumber} is less than {secondNumber}.\n{secondNumber} is greater than {firstNumber}.";
            } else {
                return $"{firstNumber} is equal to {secondNumber}.\n{secondNumber} is equal to {firstNumber}.";
            }
        }
    }
}