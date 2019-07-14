using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Type
{
    public class Employee<T> : Person
    {
        internal readonly int Length;

        public List<T> things { get; set; }
        public string fullName { get; set; }
        public int Id { get; set; }

        public void idNum()
        {
            Console.WriteLine("Employee id: " + Id);
        }
    }
}