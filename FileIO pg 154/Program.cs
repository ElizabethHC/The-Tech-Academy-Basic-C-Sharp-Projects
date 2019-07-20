using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO_pg_154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number.");
            string x = Console.ReadLine();
            File.WriteAllText(@"C:\Users\ehcottle\logs\number.txt", x);
            File.ReadAllText("C:\\Users\\ehcottle\\logs\\number.txt");

            Console.ReadLine();
        }
    }
}
