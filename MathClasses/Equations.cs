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
            Console.WriteLine("\tYour number added to 777 is: " + value);
            return value;
        }

        public int equations(decimal b)
        {
            //decimal num = b;
            //num = Decimal.ToInt32(b);
            decimal value = b * 17;
            int mult = Decimal.ToInt32(value);
            Console.WriteLine("\tYour number multiplied by 17 is: " + mult);
            return mult;
        }

        public int equations(string number)
        {
            int z = Convert.ToInt32(number);
            int value = 300 / 2 + z;
            Console.WriteLine("\t300 divided by 2 with " + number + " added is " + value + ".");
            return value;
        }
    }
}
