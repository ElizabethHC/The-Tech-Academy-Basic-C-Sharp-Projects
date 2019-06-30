using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class OneOrTwo
    {
        public int theMath(int a, int b, int input=100)
        {
            return a + b + input;
        }
    }
}
