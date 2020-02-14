using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Business.Interface
{
    interface ICalculator
    {
        dynamic Addition(dynamic number1, dynamic number2);
        dynamic Substraction(dynamic number1, dynamic number2);
        dynamic Multiplication(dynamic number1, dynamic number2);
        dynamic Division(dynamic number1, dynamic number2);

    }
}
