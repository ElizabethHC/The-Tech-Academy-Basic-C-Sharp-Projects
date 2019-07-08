using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy" );
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer “yes” or “no”.");
            var studyHelp = Console.ReadLine();
            bool needHelp = studyHelp == "yes";
            bool noHelp = studyHelp == "no";
            if (noHelp)
            {
                Console.WriteLine("I'm glad you're doing well!");
            }
            else if (needHelp)
            {
                Console.WriteLine("Please reach out for the assistance you need!");
            }
            else if (!noHelp && !needHelp)
            {
                Console.WriteLine("I'm sorry, 'yes' or 'no' answers only.");
            }

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string giveFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
