using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCalculate
{
    public class Divide : ICalculation
    {
        public string Operator => "/";

        public double Execute(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
