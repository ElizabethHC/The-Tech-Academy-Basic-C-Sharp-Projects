using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exceptions_pg165
{
    public class ZeroAndBelow : Exception
    {
        public ZeroAndBelow()
            : base() { }
        public ZeroAndBelow(string message)
            : base(message) { }
    }
}
