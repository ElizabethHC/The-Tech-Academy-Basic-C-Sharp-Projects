﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Methods
{
    static class questions
    {
        public static string qOne;
        public static string qTwo;

        static questions()
        {
            qOne = "Pick a whole number:";
            qTwo = "Pick a whole number:";
        }
    }

    class methodEquations
    {
        public static void Divide(int a, out int div, out int firstTotal)
        {
            div = 2;
            firstTotal = a / div;
            Console.WriteLine("Your number, " + a + ", divided by 2 is " + firstTotal + ".");
        }

        public int middleDiv(int a, int b)
        {
            int userTotal = a + b;
            Console.WriteLine($"The two numbers you chose ( {a} and {b} ) added together will be: {userTotal}.");
            return userTotal;
        }

        public int Divide(int firstTotal, int b, int div)
        {
            int total = (firstTotal + b) / div;
            Console.WriteLine("\nAnd your first answer, " + firstTotal + ", added to your second number, " + b + " is divided by 2 to get " + total + ".");
            return total;
        }
    }
}
