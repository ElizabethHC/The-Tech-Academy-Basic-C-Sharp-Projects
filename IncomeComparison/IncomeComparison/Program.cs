using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            //person 1
            Console.WriteLine("Person 1");
            int w;
            Console.WriteLine("Hourly Rate: ");
            w= Convert.ToInt32(Console.ReadLine());

            int x;
            Console.WriteLine("Hours worked per week: ");
            x = Convert.ToInt32(Console.ReadLine());

            //person 2
            Console.WriteLine("Person 2");
            int y;
            Console.WriteLine("Hourly Rate: ");
            y = Convert.ToInt32(Console.ReadLine());

            int z;
            Console.WriteLine("Hours worked per week: ");
            z = Convert.ToInt32(Console.ReadLine());

            //weekly salaries
            int weekSalaryP1 = w * x;
            Console.WriteLine("Weekly salary of Person 1: " + weekSalaryP1);

            int weekSalaryP2 = y * z;
            Console.WriteLine("Weekly salary of Person 2: " + weekSalaryP2);

            //salary difference
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool salaryCompare = weekSalaryP1 > weekSalaryP2;
            Console.WriteLine(salaryCompare);
            Console.ReadLine();
        }
    }
}
