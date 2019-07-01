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
            Employee name = new Employee();
            name.Ids = new List<Person>();
            name.firstName = "Sample";
            name.lastName = "Student";

            Employee id = new Employee();
            name += id;
            name -= id;

            Console.ReadLine();
        }
    }
}
