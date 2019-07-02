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
            Employee<Person> things = new Employee<Person>();
            things.fullName = "Student Sample";
            Random random = new Random();
            int num = random.Next();
            things.id = num;
            Console.WriteLine("Employee: " + things.id + ", " + things.fullName);

            Console.ReadLine();
        }
    }
}