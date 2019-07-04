using System;

namespace Pg_103
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = new string[] { "dog(s)", "cat(s)", "bird(s)", "lizard(s)", "rodent(s)" };

            for (int i = 0; i <= animals.Length - 1; i++)
            {
                Console.WriteLine("How many pets do you want?");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x <= 0)
                {
                    Console.WriteLine("You don't want any pets");
                    break;
                }
                if (x > 99)
                {
                    Console.WriteLine("You would have too many pets");
                    break;
                }

                else
                {
                    Console.WriteLine("You want " + x + " " + i);
                    break;
                }
            }
        }
    }
}
