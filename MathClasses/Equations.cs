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

        public int equations(decimal b, int mult)
        {
            decimal num = b;
            num = Decimal.ToInt32(b);
            Console.WriteLine("\tYour number multiplied by 17 is: " + num * mult);
            return mult;
        }

        public int equations(int num1, int num2, int number)
        {
            int value = num1 / num2 + number;
            Console.WriteLine("\t300 divided by 2 with " + number + " added is " + value + ".");
            return value;
        }
    }
}
