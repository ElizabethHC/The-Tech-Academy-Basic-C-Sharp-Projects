using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Type
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void sayName()
        {
            Console.WriteLine(firstName + ", " + lastName);
        }

    }
}
