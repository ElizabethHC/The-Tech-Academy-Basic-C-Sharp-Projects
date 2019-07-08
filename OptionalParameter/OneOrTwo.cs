using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class OneOrTwo
    {
        public int theMath(int a, int b)
        {
            int value1 = a + b;
            int value2 = value1 * 100;
            Console.WriteLine(a + " added to " + b + " is " + value1 + " and then multplied by 100 is " + value2); ;
            return value2;
        }

        public int theMath(int a)
        {
            int value = a + 100;
            Console.WriteLine(a + " added to 100 is: " + value);
            return value;
        }
    }
}
