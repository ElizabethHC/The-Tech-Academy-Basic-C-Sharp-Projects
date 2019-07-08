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
            Console.WriteLine("Pick a whole number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("OPTIONAL \n Pick another whole number:");
            int b;
            int result;

            var methodMath = new OneOrTwo();
            if (int.TryParse(Console.ReadLine(), out b))
            {
                result = methodMath.theMath(a, b);
            }
            else
            {
                result = methodMath.theMath(a);
            }
            Console.ReadLine();
        }
    }
}
