using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCalculate
{
    public interface ICaller
    {
        public ICalculation GetCalculation(string op);
    }
}
