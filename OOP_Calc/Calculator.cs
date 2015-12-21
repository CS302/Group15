using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calc
{
    class Calculator
    {
        //private delegate double OperationDelegate(double x, double y);
        private Dictionary<string, Func<double, double, double>> _operations;

        public Calculator()
        {
            _operations = new Dictionary<string, Func<double, double, double>>
            {
                {"+", (x, y) => x + y}, {"-", (x, y) => x - y}, {"*", (x, y) => x * y}, {"/", (x, y) => x / y}
            };
        }

        public double PerformOperation(string op, double x, double y)
        {
            #region 2nd
            /*
            switch (op)
            {
                case "+": return Addition(x, y);
                case "-": return Substraction(x, y);
                case "*": return Multiplication(x, y);
                case "/": return Division(x, y);
                default: throw new ArgumentException(string.Format("Operation {0} is invalid.", op), "op");
            }*/
            #endregion

            #region 3rd
            if (!_operations.ContainsKey(op))
                throw new ArgumentException(string.Format("Operation {0} is invalid.", op), "op");
            return _operations[op](x, y);
            #endregion
        }

        public void DefineOperation(string op, Func<double, double, double> body)
        {
            if (_operations.ContainsKey(op))
                throw new ArgumentException(string.Format("Operation {0} is already exists.", op), "op");
            _operations.Add(op, body);
        }

        //private double Addition(double x, double y) 
        //{ 
        //    // Здесь могут быть проверки
        //    return x + y; 
        //}
        //private double Substraction(double x, double y)
        //{
        //    return x - y;
        //}
        //private double Multiplication(double x, double y)
        //{
        //    return x * y;
        //}
        //private double Division(double x, double y)
        //{
        //    return x / y;
        //}

    }
}
