using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator___Employee
{
    public class Employee : Person
    {
        public List<Person> Ids { get; set; }
        public override void sayName()
        {
            Console.WriteLine("Employee Name: ");
            base.sayName();
        }

        public void Id()
        {
            int num = 45;
            Console.WriteLine("Employee id: " + num);
        }
    }
}
