using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            methodEquations userMath = new methodEquations();

            Console.WriteLine("Pick a whole number:");
            int a = Convert.ToInt32(Console.ReadLine());

            int firstTotal = userMath.Divide(a, 2);
            Console.WriteLine("Your number, " + a + " divided by 2 is " + firstTotal + ".");

            Console.WriteLine("Pick another whole number:");
            int b = Convert.ToInt32(Console.ReadLine());

            userMath.middleDiv(a, b);


            int secondTotal = userMath.Divide(firstTotal, b, 2);
            Console.WriteLine("\nAnd your first answer, " + firstTotal + " added to your second number, " + b + " is divided by 2 to get " + secondTotal + ".");
        }
    }
}
