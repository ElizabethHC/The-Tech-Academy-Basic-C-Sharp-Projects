using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Equation
    {
        public int equations(int a, int plus)
        {
            int value = a + plus;
            Console.WriteLine("\tYour number added to 777 is: " + value);
            return value;
        }

        public decimal equations(decimal b, int mult)
        {
            decimal value = b * mult;
            Console.WriteLine("\tYour number multiplied by 17 is: " + value);
            return value;
        }

        public int equations(int num1, int num2, int z)
        {
            int value = num1 / num2 + z;
            Console.WriteLine("\t300 divided by 2 with your number added is " + value + ".");
            return value;
        }
    }
}
