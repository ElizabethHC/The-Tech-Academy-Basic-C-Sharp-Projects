using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator___Employee
{
    public class Employee : Person
    {
        public int Id { get; set; }
        public int employee1 { get; set; }
        public int employee2 { get; set; }

        public void idNum()
        {
            Console.WriteLine("Employee id: " + Id);
        }
    }
}
