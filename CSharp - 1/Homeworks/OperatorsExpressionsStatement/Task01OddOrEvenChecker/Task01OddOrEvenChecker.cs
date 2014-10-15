using System;

class Task01OddOrEvenChecker
{
    static void Main(string[] args)
    {
        int intNumber = 0;

        try
        {
            Console.WriteLine("Enter an integer number: ");
            intNumber = int.Parse(Console.ReadLine());

            if (intNumber % 2 == 0)
                Console.WriteLine("The number is even!");
            else
                Console.WriteLine("The number is odd!");
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You entered a letter or symbol!");
        }
    }
}
