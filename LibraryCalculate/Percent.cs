using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCalculate
{
    internal class Percent : ICalculation
    {
        public string Operator => "%";

        public double Execute(double firstNumber, double secondNumber)
        {
            return (firstNumber / 100) * secondNumber;
        }
    }
}
