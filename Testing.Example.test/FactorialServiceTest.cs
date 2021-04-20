using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDExample;
using Xunit;

namespace Testing.Example.test
{
    public class FactorialServiceTest
    {
        /// <summary>
        /// Calculate factorial of zero.
        /// </summary>
        [Fact]
        public void TestFactorialZero() 
        {
            FactorialService factorialService = new FactorialService();
            int result = factorialService.Calculate(0);
            Assert.Equal(1,result);
        }
        /// <summary>
        /// Calculate factorial of five.
        /// </summary>
        [Fact]
        public void testFactorialFive() 
        {
            FactorialService factorialService = new FactorialService();
            int result = factorialService.Calculate(5);
            Assert.Equal(120, result);
        }
    }
}
