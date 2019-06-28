using System;


class Program
{
    static void Main(string[] args)
    {
        try
        { 
            int[] numberDivide = { 10, 47, 8, 13 };
            Console.WriteLine("Pick a number to be divide by the array numbers.");
            int x;
            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberDivide.Length; i++)
            {
                int numberThree = numberDivide[i] / x;
                Console.WriteLine(numberDivide[i] + " divided by " + x + " equals " + numberThree);
            }
        Console.ReadLine(); 

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please write one whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Don't divide by zero, silly.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
    }
}

