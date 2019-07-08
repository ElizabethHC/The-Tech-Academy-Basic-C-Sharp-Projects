using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            var currentCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            var studyHelp = Console.ReadLine();
            var needHelp = Convert.ToBoolean(studyHelp);
            var noHelp = Convert.ToBoolean(studyHelp);

            Console.WriteLine("Were there any positive experiences you’d like to share? please give specifics.");
            var posExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            var giveFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int studyHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
