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
            Console.WriteLine("Pick a whole number for addition: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Equation equation1 = new Equation();
            equation1.equations(a, 777);

            Console.WriteLine("\nPick a decimal number for multiplying: ");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            Equation equation2 = new Equation();
            equation2.equations(b, 17);

            Console.WriteLine("\nPick a whole number to be added to the equation: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Equation equation3 = new Equation();
            equation3.equations(300, 2, z);

            Console.ReadLine();

        }
    }
}
