using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exceptions_pg165
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What's your age?");
                int x = Convert.ToInt32(Console.ReadLine());

                DateTime dateAndTime = DateTime.Now;
                DateTime yearBorn = dateAndTime.AddYears(-x);
                if (x <= 0)
                {
                    throw new ZeroAndBelow();
                }
                else
                {
                    Console.WriteLine("You were born around " + yearBorn.ToString("yyyy") + ".");
                }
            }

            catch(ZeroAndBelow)
            {
                Console.WriteLine("I'm sorry but that is not possible. Please enter a valid age.");
                Console.ReadLine();
                return;
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter your age as a whole number.");
                Console.ReadLine();
                return;
            }

            Console.ReadLine();
        }
    }
}
