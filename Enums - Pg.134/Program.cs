using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums___Pg._134
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello user, what is the current day of the week? (type 1 for monday, 2 for sunday and so on)");
                var answer = Convert.ToChar(Console.ReadLine());
                string value;
                value = answer.ToString();

                daysOfTheWeek day = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), value);
                if (day == daysOfTheWeek.monday)
                {
                    Console.WriteLine("The day is monday");
                }
                if (day == daysOfTheWeek.tuesday)
                {
                    Console.WriteLine("The day is tuesday");
                }
                if (day == daysOfTheWeek.wednesday)
                {
                    Console.WriteLine("The day is wednesday");
                }
                if (day == daysOfTheWeek.thursday)
                {
                    Console.WriteLine("The day is thursday");
                }
                if (day == daysOfTheWeek.friday)
                {
                    Console.WriteLine("The day is friday");
                }
                if (day == daysOfTheWeek.saturday)
                {
                    Console.WriteLine("The day is saturday");
                }
                if (day == daysOfTheWeek.sunday)
                {
                    Console.WriteLine("The day is sunday");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week, remember there are only SEVEN days in a week...");
            }
            finally
            {
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
