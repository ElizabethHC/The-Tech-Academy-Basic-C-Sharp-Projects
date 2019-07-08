using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class OneOrTwo
    {
        public int theMath(int a, int b=0)
        {
            int value1 = a + b;
            int value2 = value1 * 100;
            Console.WriteLine(a + " added to " + b + " is " + value1 + " and then multplied by 100 is " + value2); ;
            return value2;
        }
    }
}
