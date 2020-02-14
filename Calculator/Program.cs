using static System.Console;
using Calculator.Business.Interface;
using Calculator.Business.Implementation;

namespace Calculator
{
    class Program
    {
        ICalculator calculator = null;
        public Program(ICalculator calc)
        {
            calculator = calc;
        }
        static void Main(string[] args)
        {
            var program = new Program(new BaseCalculator());

            WriteLine(program.calculator.Addition(5,5));
            WriteLine(program.calculator.Division(5, 5));
            WriteLine(program.calculator.Multiplication(5, 5));
            WriteLine(program.calculator.Substraction(5, 5));

            ReadLine();
        }
    }
}
