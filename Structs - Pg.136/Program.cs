using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs___Pg._136
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 3.6;
            decimal decNumber = System.Convert.ToDecimal(number);

            Number first = new Number();
            first.Answer = decNumber;
            Console.WriteLine(first.Answer);

            Console.ReadLine();
        }
    }
}
