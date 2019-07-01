using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee : Person, IQuittable
    {
        public override void sayName()
        {
            Console.WriteLine("Employee Name: ");
            base.sayName();
        }

        //public void Id()
        //{
        //    Random random = new Random();
        //    int num = random.Next();
        //    Console.WriteLine("Employee id: " + num);
        //}

        public void Quit()
        {
            Console.WriteLine("An employee has resigned.");

        }
    }
}
