using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Type
{
    public class Employee<T> : Person
    {
        public List<T> things { get; set; }
        public string fullName { get; set; }
        public int id { get; set; }
    }
}