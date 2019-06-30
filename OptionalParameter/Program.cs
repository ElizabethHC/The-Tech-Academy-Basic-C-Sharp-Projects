using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            var methodMath = new OneOrTwo();

            Console.WriteLine("Pick a whole number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("OPTIONAL \n Pick another whole number:");

            int b;
            int result;
            if (int.TryParse(Console.ReadLine(), out b))
            {
                result = methodMath.theMath(a, b, 100);
            }
            else
            {
                result = methodMath.theMath(a, 100);
            }

            var theAnswer = methodMath.theMath(a, b, 100);
            Console.WriteLine("Your number(s) added to 100 is: " + theAnswer);

            Console.ReadLine();
        }
    }
}
