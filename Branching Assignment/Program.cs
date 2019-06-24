using System;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            decimal packageWeight;
            Console.WriteLine("How much does the package weigh?");
            packageWeight = Convert.ToDecimal(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
                Environment.Exit(0);
            }
            else if (packageWeight <= 50)
            {
                Console.WriteLine("What is the width?");
                decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("What is the height?");
                decimal packageHeight = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("What is the length?");
                decimal packageLength = Convert.ToDecimal(Console.ReadLine());

                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Environment.Exit(0);
                }
                else if (packageWidth + packageHeight + packageLength <= 50)
                {
                    decimal packageTotal = (packageWidth + packageHeight + packageLength) * packageWeight;
                    decimal quotient = packageTotal /100;
                    quotient = (decimal)System.Math.Round(quotient, 2);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quotient);
                }
            }


        }
    }
}
