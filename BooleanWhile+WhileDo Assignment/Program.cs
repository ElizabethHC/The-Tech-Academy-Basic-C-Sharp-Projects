using System;

namespace BooleanWhileAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old am I?");
            int x = Convert.ToInt32(Console.ReadLine());

            bool trueAge = x == 25;

            while (x >= 32)
            {
                Console.WriteLine("You chose " + x + "? Too high.");
                Console.WriteLine("Try again.");
                x = Convert.ToInt32(Console.ReadLine());
            }

            while (x <= 19)
            {
                Console.WriteLine("You chose " + x + "? A bit young.");
                Console.WriteLine("Try again.");
                x = Convert.ToInt32(Console.ReadLine());
            }

            do
            {
                switch (x)
                {
                    case 25:
                        Console.WriteLine("Spot on!");
                        trueAge = true;
                        break;
                    default:
                        Console.WriteLine("You chose " + x + " as my age... Close but not it!");
                        Console.WriteLine("Try again.");
                        x = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!trueAge);

            Console.ReadLine();

        }
    }
}