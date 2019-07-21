using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTime_Pg156
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("The current date and time is: " + currentDateTime);

            Console.WriteLine("Pick a number.");
            int x = Convert.ToInt32(Console.ReadLine());

            DateTime xHoursLater = currentDateTime.AddHours(x);
            Console.WriteLine("In " + x + " hours the time will be: " + xHoursLater);

            Console.ReadLine();
        }
    }
}
