using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator___Employee
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public static Employee operator+ (Employee id, Person name)
        {
            id.Ids.Add(name);
            return id;
        }

        public static Employee operator- (Employee id, Person name)
        {
            id.Ids.Remove(name);
            return id;
        }

        public virtual void sayName()
        {
            Console.WriteLine(firstName + ", " + lastName);
        }

    }
}
