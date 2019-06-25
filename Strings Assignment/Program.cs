using System;
using System.Text;

namespace Strings_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("A great man once said, " +
                "\"I admire its purity. A survivor, unclouded by conscience, remorse, or delusions of morality.\" -Ash (Alien, 1979)");

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("\nInteresting how morality can be so different from person to person, even when things seem so black and white.");

            string userName = "student";
            string schoolName = "The Tech Academy";
            string date = "June 24th, 2019";

            userName = userName.ToUpper();

            StringBuilder quote = new StringBuilder();
            quote.Append("\nThis was an assignment from " + schoolName +
                " created by " + userName +
                ". \nPlease enjoy!\n\t" + date);

            StringBuilder sb2 = new StringBuilder();
            sb2.Append("\nThank you for reading.");

            Console.WriteLine(sb);

            Console.WriteLine(sb1);
            Console.WriteLine(quote);
            Console.WriteLine(sb2);
        }
    }
}
