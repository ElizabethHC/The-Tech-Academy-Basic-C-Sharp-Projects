using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator___Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.firstName = "First";
            employee1.lastName = "Student";
            employee1.Id = 07;
            employee1.sayName();
            employee1.idNum();

            Employee employee2 = new Employee();
            employee2.firstName = "Second";
            employee2.lastName = "Student";
            employee2.Id = 32;
            employee2.sayName();
            employee2.idNum();

            if (employee1.Id == employee2.Id)
                Console.WriteLine("Error: employees have the same id.");
            else
                Console.WriteLine("These employees do not have the same id.");

            Console.ReadLine();
        }
    }
}
