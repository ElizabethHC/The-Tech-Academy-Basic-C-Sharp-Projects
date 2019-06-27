using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
        List<int> playerNumber = new List<int>();
        playerNumber.Add(5);
        playerNumber.Add(29);
        playerNumber.Add(1);
        playerNumber.Add(15);
        Console.WriteLine("Select 0, 1, 2, or 3...");
        int a;
        a = Convert.ToInt32(Console.ReadLine());
        
        while (a > 3)
        {
            Console.WriteLine("Again... Select 0, 1, 2, or 3...");
            a = Convert.ToInt32(Console.ReadLine());
        }

        List<string> classList = new List<string>() { "berserker", "healer", "mage", "tank", "warrior", "assassin", "ranger" };
        Console.WriteLine(string.Join("\n", classList));
        Console.WriteLine("\nHello player " + playerNumber[a] + ", please select class from the above options. \nConfused on how to select a class? 0=Berserker, 6=Ranger, and so on.");
        int x;
        x = Convert.ToInt32(Console.ReadLine());
        while (x > 6)
        {
            Console.WriteLine("Please select your class using the numbers 0 to 6. Let's try again.");
            x = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\tHmm you want to be a(n) " + classList[x] + ", interesting.");


        int[] levelArray = { 1, 7, 33, 68, 100, 14 };
        Console.WriteLine("\nNow pick a number between 0 and 5 to generate your random level. Best of luck player!");
        int y;
        y = Convert.ToInt32(Console.ReadLine());

        while (y > 5)
        {
            Console.WriteLine("Sorry player but you can only select a number from 0 to 5! Try once more...");
            y = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\tLooks like your generated level is " + levelArray[y] + ", hope that's good enough for you.");

        Console.WriteLine("\nSo all in all your level as a(n) " + classList[x] + " is: " + levelArray[y] +"! Good luck, player " + playerNumber[a] + ".");

        Console.ReadLine();
        }
    }
