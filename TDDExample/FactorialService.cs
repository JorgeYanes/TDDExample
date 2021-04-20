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
            
            if (number == 0)
            {
                return 1;
            }

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

    }
}
