using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Business.Interface;

namespace Calculator.Business.Implementation
{
    class BaseCalculator : ICalculator
    {
        public dynamic Addition(dynamic number1, dynamic number2)
        {
            return number1 + number2;
        }

        public dynamic Division(dynamic number1, dynamic number2)
        {
            return number1 / number2;
        }

        public dynamic Multiplication(dynamic number1, dynamic number2)
        {
            return number1 * number2;
        }

        public dynamic Substraction(dynamic number1, dynamic number2)
        {
            return number1 - number2;
        }
    }
}
