using System;
using System.Collections.Generic;

namespace Pg_103
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = new string[] { "dog(s)", "cat(s)", "bird(s)", "lizard(s)", "rodent(s)" };

            for (int j = 0; j < 1; j++, j--)
            {
                Console.WriteLine("Welcome to this project.");

                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("How many pets do you want?");
                    int x = Convert.ToInt32(Console.ReadLine());

                    if (x <= 0)
                    {
                        Console.WriteLine("You don't want any pets");
                        break;
                    }
                    if (x > 99)
                    {
                        Console.WriteLine("You would have too many pets");
                        break;
                    }

                    else
                    {
                        foreach (string str in animals)
                            Console.WriteLine("You want " + x + " " + str);
                    }
                }
                break;
            }

            List<string> uniques = new List<string>()
            {
                "Annie", "Anna", "Anne", "Annette"
            };

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("\nNow pick a letter:");
                var y = Convert.ToChar(Console.ReadLine());

                if (y == 'a')
                {
                    Console.WriteLine(uniques[0] + ", " + uniques[1] + ", " + uniques[2] + ", " + uniques[3]);
                }
                else if (y == 'n')
                {
                    Console.WriteLine(uniques[0] + ", " + uniques[1] + ", " + uniques[2] + ", " + uniques[3]);
                }
                else if (y == 'e')
                {
                    Console.WriteLine(uniques[0] + ", " + uniques[2] + ", " + uniques[3]);
                }
                else if (y == 'i')
                {
                    Console.WriteLine(uniques[0]);
                }
                else if (y == 't')
                {
                    Console.WriteLine(uniques[3]);
                }
                else
                {
                    Console.WriteLine("No matches found for this.");
                }
            }

            List<string> duplicate = new List<string>()
            {
                "a", "b", "c", "d", "b"
            };

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("\nNow pick another letter:");
                var z = Convert.ToChar(Console.ReadLine());

                if (z == 'b')
                {
                    int a = duplicate.IndexOf("b");
                    while (a != -1)
                    {
                        Console.WriteLine("We found that number on the indices: " + a + ".");
                        a = duplicate.IndexOf("b", a + 1);
                    }
                }
                else if (z == 'a')
                {
                    var a = duplicate.IndexOf("a");
                    Console.WriteLine("We found that number on the index: " + a + ".");

                }
                else if (z == 'c')
                {
                    var a = duplicate.IndexOf("c");
                    Console.WriteLine("We found that number on the index: " + a + ".");
                }
                else if (z == 'd')
                {
                    var a = duplicate.IndexOf("d");
                    Console.WriteLine("We found that number on the index: " + a + ".");
                }
                else
                {
                    Console.WriteLine("Sorry, that letter was not located.");
                }
            }

            List<string> daysWeek = new List<string>()
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Tuesday", "Friday", "Saturday", "Sunday"
            };
            List<string> duplicates = new List<string>();

            Console.WriteLine(string.Join("\n" , daysWeek));
            foreach (var days in daysWeek)
            {
                if (days == "Tuesday")
                {
                    duplicates.Add(days);
                    Console.WriteLine("It seems there are duplicates of some days: " + days);
                    break;
                }

            }

        }
    }
}
