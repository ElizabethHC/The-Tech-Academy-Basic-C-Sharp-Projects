using System;


namespace Pg113_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var methodMath = new Math();
                Console.WriteLine("Pick a whole number for multiplication: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick another whole number for multiplication: ");
                int z = Convert.ToInt32(Console.ReadLine());
                methodMath.Mult(y, z, 4);
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
