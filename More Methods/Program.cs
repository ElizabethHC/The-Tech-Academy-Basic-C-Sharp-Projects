using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            methodEquations userMath = new methodEquations();

            Console.WriteLine(questions.qOne);
            int a = Convert.ToInt32(Console.ReadLine());
            int div;
            int firstTotal;
            methodEquations.Divide(a, out div, out firstTotal);

            Console.WriteLine(questions.qTwo);
            int b = Convert.ToInt32(Console.ReadLine());

            userMath.middleDiv(a, b);

            int secondTotal = userMath.Divide(firstTotal, b, 2);
        }
    }
}