using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeePosition = new Employee<string>();
            employeePosition.things = new List<string>() { "Customer Service Rep", "Sales Associate", "Floater", "Regional Manager", "Accountant" };
            employeePosition.things.ForEach(i => Console.Write("{0}\n", i));

            Employee<int> employeeWage = new Employee<int>();
            employeeWage.things = new List<int>() { 10, 13, 15, 20, 23, 30 };
            employeeWage.things.ForEach(i => Console.Write("${0}\n", i));

            Console.ReadLine();
        }
    }
}