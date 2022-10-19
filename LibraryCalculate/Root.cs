using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCalculate
{
    internal class Root : ICalculation
    {
        public string Operator => "Rt";

        public double Execute(double firstNumber, double secondNumber)
        {
            if (firstNumber >= 0)
                return Math.Pow(firstNumber, 1 / secondNumber);
            else
                throw new ArgumentException("Error");
        }
    }
}
