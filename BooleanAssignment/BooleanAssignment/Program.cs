using System;

namespace BooleanAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your age?");
            int x;
            x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Have you ever had a DUI? 'true' or 'false' answer only.");
            var dui = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int z;
            z = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Qualified?");
            bool legalAge = x > 15;
            bool legalDUI = dui == "false";
            bool legalTickets = z <= 3;
            bool qualifyAll = legalAge && legalDUI && legalTickets;

            if (qualifyAll)
            {
                Console.WriteLine("True");
            }
            else if (!legalAge)
            {
                Console.WriteLine("False");
            }

            else if (!legalDUI)
            {
                Console.WriteLine("False");
            }
            else if (!legalTickets)
            {
                Console.WriteLine("False");
            }

            Console.ReadLine();
        }
    }
}
