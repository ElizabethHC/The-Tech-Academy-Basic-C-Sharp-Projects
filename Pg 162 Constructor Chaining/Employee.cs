using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_162_Constructor_Chaining
{
    public class Employee : Person
    {
        public int Id { get; set; }
        public string fullName { get; set; }

        public Employee(string firstName = "", string lastName = "") : this(200)
        {
            fullName = firstName + " " + lastName;
            this.fullName = fullName;

        }

        public Employee(int Id = 0)
        {
            this.Id = Id;
        }

    }
}
