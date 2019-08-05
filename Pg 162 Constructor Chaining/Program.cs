using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pg_162_Constructor_Chaining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name?");
            var x = Console.ReadLine();
            Console.WriteLine("What's your last name?");
            var y = Console.ReadLine();
            Employee employee1 = new Employee(x, y);
            Console.WriteLine("New employee, " + employee1.fullName + ", has the id# " + employee1.Id);

            Console.ReadLine();
        }
    }
}
