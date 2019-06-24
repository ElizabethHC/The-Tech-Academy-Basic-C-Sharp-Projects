using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int multiplyResult;

            Console.WriteLine("Enter a number to be multiplied: ");
            x = Convert.ToInt32(Console.ReadLine());
            multiplyResult = x * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + multiplyResult);


            int y;
            int addResult;

            Console.WriteLine("Enter a number to be added: ");
            y = Convert.ToInt32(Console.ReadLine());
            addResult = y + 25;
            Console.WriteLine("Your number plus 25 is: " + addResult);


            int z;

            Console.WriteLine("Enter a number to be divided: ");
            z = Convert.ToInt32(Console.ReadLine());
            double quotient = z / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + quotient);


            int a;
            int currentInput = 50;

            Console.WriteLine("Enter a number to see if it's greater than fifty: ");
            a = Convert.ToInt32(Console.ReadLine());
            bool bigFifty = a >= currentInput;
            Console.WriteLine(bigFifty);

            int b;

            Console.WriteLine("Enter a number to be divided and find the remainder: ");
            b = Convert.ToInt32(Console.ReadLine());
            int remainder = b % 7;
            Console.WriteLine("Your number divided by seven will have a remainder of: " + remainder);
            Console.ReadLine();

        }
    }
}
