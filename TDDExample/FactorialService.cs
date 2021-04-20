using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExample
{
    public class FactorialService
    {
        public int Calculate(int number) 
        {
            if (number == 0 || number == 1)
                return 1;
            else
                return number * Calculate(number - 1);
        }

    }
}
