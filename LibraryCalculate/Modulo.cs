using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCalculate
{
    internal class Modulo : ICalculation
    {
        public string Operator => "MOD";

        public double Execute(double firstNumber, double secondNumber)
        {
            return firstNumber % secondNumber;
        }
    }
}
