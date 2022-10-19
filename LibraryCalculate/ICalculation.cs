using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCalculate
{
    public interface ICalculation
    {
        string Operator { get; }

        double Execute(double firstNumber, double secondNumber);

    }
}
