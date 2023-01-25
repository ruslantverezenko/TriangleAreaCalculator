using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            double square1 = calc.CalcTriangleSquare(10, 20);
            double square2 = calc.CalcTriangleSquare(40, 20, 30);
            double square3 = calc.CalcTriangleSquare(10, 20, 50);

            Console.WriteLine($"Square1 = {square1}\nSquare2 = {square2}\nSquare3 = {square3} ");
        }
    }
}
