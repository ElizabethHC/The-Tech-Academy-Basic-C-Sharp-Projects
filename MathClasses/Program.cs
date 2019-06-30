using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var equation1 = new Equation();
            Console.WriteLine("Pick a whole number for addition: ");
            int a = Convert.ToInt32(Console.ReadLine());
            var answer1 = equation1.Add(a, 777);
            Console.WriteLine("\tYour number added to 777 is: " + answer1);

            var equation2 = new Equation();
            Console.WriteLine("\nPick a decimal number for multiplying: ");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            decimal answer2 = equation2.Multiply(b, 17);
            Console.WriteLine("\tYour number multiplied by 17 is: " + answer2);

            var equation3 = new Equation();
            Console.WriteLine("\nPick a whole number to be added to the equation: ");
            string x = "300";
            string y = "2";
            int first = 0, second = 0;
            int z = Convert.ToInt32(Console.ReadLine());
            Int32.TryParse(x, out first);
            Int32.TryParse(y, out second);
            var answer3 = equation3.stringInt(first, second, z);
            Console.WriteLine("\t300 divided by 2 with your number added is " + answer3 + ".");

            Console.ReadLine();

        }
    }
}
