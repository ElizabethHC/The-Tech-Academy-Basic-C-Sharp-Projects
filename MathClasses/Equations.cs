using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    class Equation
    {
        public int Add(int a, int plus)
        {
            return a + plus;
        }

        public decimal Multiply(decimal b, int mult)
        {
            return b * mult;
        }

        public int stringInt(int num1, int num2, int z)
        {
            return num1 / num2 + z;
        }
    }
}
