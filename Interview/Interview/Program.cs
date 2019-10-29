using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Press enter to continue after each example.");
            Console.ReadLine();

            //adding odd numbers
            int[] numbers = new int[8] { 1, 43, 3, 97, 27, 16, 8, 31 };
            Console.WriteLine("Adding only the odd numbers from this array: [{0}]", string.Join(", ", numbers));
            List<int> oddNumbers = new List<int>();
            foreach (int odds in numbers)
            {
                if (odds % 2 == 1)
                {
                    oddNumbers.Add(odds);
                }
            }
            int oddSum = oddNumbers.Sum(x => Convert.ToInt32(x));
            Console.WriteLine("Answer: " + oddSum);
            Console.ReadLine();
            //end odd addition

            //adding large integers
            long[] largeNumbers = new long[5] { 320000000, 19532222, 77699999999, 4509, 1022 };
            Console.WriteLine("Adding large integers: [{0}]", string.Join(", ", largeNumbers));
            long bigSum = largeNumbers.Sum(y => Convert.ToInt64(y));
            Console.WriteLine("Answer: " + bigSum);
            Console.ReadLine();
            //end large integer addition

            //reverse string
            string[] a = new string[] { "desrever eb lliw siht" };
            Console.WriteLine("The string: [{0}]", string.Join("", a));
            var reversed = a.Reverse().Select(z => new string(a.Reverse().ToString()));
            Console.WriteLine(string.Join("", a).Reverse().ToArray());
            Console.ReadLine();
            //end reverse

            //remove repeated letters
            string b = "ooraangeees";
            Console.WriteLine("Removing extra letters in: [{0}]", string.Join("", b));
            var duped = b.Split(" ").Distinct();
            Console.WriteLine(string.Join("", b).Distinct().ToArray());
            Console.ReadLine();
            //end remove repeats

            //FizzBuzz
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
                //end FizzBuzz

                Console.ReadLine();
        }
    }
}
