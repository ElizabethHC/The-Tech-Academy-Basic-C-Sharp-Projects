using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg113_Assignment
{
    public class Math
    {
        public void Mult(int y, int z)
        {
            int firstNum = y;
            int secondNum = z;
            int value1 = y * 2;
            Console.WriteLine("Your first input, " + y + ", multiplied by 2 is " + value1 + ".");

            int value2 = value1 * z;
            Console.WriteLine("The first answer, " + value1 + ", multiplied by " + z + " is " + value2 + ".");
        }
    }
}
