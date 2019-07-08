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
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick another whole number: ");
                int z = Convert.ToInt32(Console.ReadLine());

                Math methodMath = new Math();
                methodMath.Mult(y, z);
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
