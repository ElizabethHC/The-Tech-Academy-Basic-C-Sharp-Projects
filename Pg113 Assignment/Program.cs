using System;


namespace Pg113_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a whole number: ");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick another whole number: ");
                int second = Convert.ToInt32(Console.ReadLine());

                Math methodMath = new Math();
                methodMath.Mult(first, second);
                methodMath.Mult(y: first, z: second);
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
