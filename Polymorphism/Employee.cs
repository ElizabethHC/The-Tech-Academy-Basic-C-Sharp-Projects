using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public void idNum()
        {
            Console.WriteLine("Employee id: " + Id);
        }

        public override void sayName()
        {
            Console.WriteLine("Employee Name: ");
            base.sayName();
        }

        public void Quit()
        {
            Console.WriteLine("An employee has resigned.");

        }
    }
}
