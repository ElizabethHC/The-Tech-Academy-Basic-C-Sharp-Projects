using System;
using System.Collections.Generic;
using System.Linq;

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

            List<string> color = new List<string>()
            {
                "red", "blue", "yellow"
            };

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("\nPick a primary color.");
                var y = Console.ReadLine();
                string lower = Convert.ToString(y);
                lower = y.ToLower();

                if (lower == "red")
                {
                    var red = color.IndexOf("red");
                    Console.WriteLine("The color you selected is a primary color and is located on the index: " + red);
                }
                else if (lower == "blue")
                {
                    var blue = color.IndexOf("blue");
                    Console.WriteLine("The color you selected is a primary color and is located on the index: " + blue);
                }
                else if (lower == "yellow")
                {
                    var yellow = color.IndexOf("yellow");
                    Console.WriteLine("The color you selected is a primary color and is located on the index: " + yellow);
                }
                else
                {
                    Console.WriteLine("Sorry, either you misspelled the color or you did not choose a primary color. "
                        + y + " is not on the list. The primary colors are 'red', 'blue', and 'yellow'.");
                }
            }


            Console.WriteLine("\nNow pick any color:");
            string z = Console.ReadLine();

            List<string> color2 = new List<string>()
            {
                "blue", "red", "green", "yellow", "blue", "yellow"
            };

            var list1 = new List<string>();
            var duplicates = new List<string>();

            foreach (var color0 in color2)
            {
                if (!list1.Contains(color0))
                    list1.Add(color0);
                else
                    duplicates.Add(color0);
            }

            var match = duplicates;
            var match2 = list1;
            if (z == "blue")
            {
                var blue = color2.IndexOf("blue");
                var blue2 = color2.LastIndexOf("blue");
                Console.WriteLine("\tThe color you selected has duplicates, the index for them is: " + blue + " and " + blue2);
            }
            else if (z == "yellow")
            {
                var yellow = color2.IndexOf("yellow");
                var yellow2 = color2.LastIndexOf("yellow");
                Console.WriteLine("\tThe color you selected has duplicates, the index for them is: " + yellow + " and " + yellow2);
            }
            else if (z == "red")
            {
                var red = color2.IndexOf("red");
                Console.WriteLine("That color is on the index: " + red);
            }
            else if (z == "green")
            {
                var green = color2.IndexOf("green");
                Console.WriteLine("That color is on the index: " + green);
            }
            else
            {
                Console.WriteLine("No match.");
            }


            Console.WriteLine("Comparing lists of animals. \nThe Two Lists...");

            List<string> favAnimal = new List<string>()
        {
            "crocodile", "fox", "octopus", "shark", "bear"
        };
            Console.WriteLine(string.Join(" ", favAnimal));

            List<string> apexPredators = new List<string>()
        {
            "polar-bear", "crocodile", "tiger", "shark", "lion"
        };
            Console.WriteLine(string.Join(" ", apexPredators));

            Console.WriteLine("Now for the similarities of these lists.");

            foreach (string animal in favAnimal.Intersect(apexPredators))
            {
                Console.WriteLine("\nThis animal is on both lists: " + animal);
            }
        }
    }
}
