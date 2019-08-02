using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda___Pg._140
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
