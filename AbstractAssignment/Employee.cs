using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    public class Employee : Person
    {
        public void Id()
        {
            Random random = new Random();
            int num = random.Next();
            Console.WriteLine("Employee id: " + num);
        }

        public override void sayName()
        {
            Console.WriteLine("Employee Name: ");
            base.sayName();
        }
    }
}
