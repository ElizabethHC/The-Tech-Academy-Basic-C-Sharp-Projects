using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda___Pg._140
{
    public class Employee : Person
    {
        public string fullName { get; set; }
        public int Id { get; set; }

        public void idNum()
        {
            Console.WriteLine("Employee id: " + Id);
        }
    }
}
