using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Equation
    {
        public int equations(int a)
        {
            int value = a + 777;
            return value;
        }

        public int equations(decimal b)
        {
            //decimal num = b;
            //num = Decimal.ToInt32(b);
            decimal value = b * 17;
            int mult = Decimal.ToInt32(value);
            return mult;
        }

        public int equations(string number)
        {
            int z = Convert.ToInt32(number);
            int value = 300 / 2 + z;
            return value;
        }
    }
}
