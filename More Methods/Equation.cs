using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Methods
{
    class methodEquations
    {
        public int Divide(int a, int div)
        {
            int total = a / div;
            return total;
        }

        public void middleDiv(int a, int b)
        {
            int userTotal = a + b;
            Console.WriteLine($"The two numbers you chose ( {a} and {b} ) added together will be: {userTotal}.");
        }

        public int Divide(int firstTotal, int b, int div)
        {
            int total = (firstTotal + b) / div;
            return total;
        }
    }
}
