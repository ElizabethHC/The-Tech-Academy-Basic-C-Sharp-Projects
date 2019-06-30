using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Person name = new Person();
            name.firstName = "Sample ";
            name.lastName = "Student";
            name.sayName();
            Employee id = new Employee();
            id.Id();
            Console.ReadLine();
        }
    }
}
