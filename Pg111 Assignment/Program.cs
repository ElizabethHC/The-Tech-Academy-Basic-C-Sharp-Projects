using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg111_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var methodMath = new Math();

                Console.WriteLine("Pick a whole number for addition: ");
                int x = Convert.ToInt32(Console.ReadLine());
                var answer1 = methodMath.Add(x, 136);
                Console.WriteLine("Your number added to 136 is: " + answer1);

                Console.WriteLine("\nPick a whole number for subtraction: ");
                int y = Convert.ToInt32(Console.ReadLine());
                var answer2 = methodMath.Sub(y, 7);
                Console.WriteLine("Your number subtracted by 7 is: " + answer2);

                Console.WriteLine("\nPick a whole number for multiplication: ");
                int z = Convert.ToInt32(Console.ReadLine());
                var answer3 = methodMath.Mult(z, 4);
                Console.WriteLine("Your number multiplied by 4: " + answer3);
                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please write one whole number.");
                return;
            }
            finally
            {
                Console.ReadLine();
            }


        }
    }
}
