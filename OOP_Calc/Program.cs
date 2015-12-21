using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            //Console.WriteLine(calc.PerformOperation("+", 157, 391));
            calc.DefineOperation(("mod"), (x, y) => x % y);
            var mod = calc.PerformOperation("mod", 1397, 14);
            Console.WriteLine(mod);

            Console.ReadLine();
        }
    }
}
