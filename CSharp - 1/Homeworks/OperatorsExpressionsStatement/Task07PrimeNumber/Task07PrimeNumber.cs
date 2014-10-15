using System;

class Task07PrimeNumber
{
    static void Main(string[] args)
    {
        int number = 0;
        try
        {
            do
            {
                Console.WriteLine("Enter number : ");
                number = int.Parse(Console.ReadLine());
            }
            while (number > 100);
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Number isn't prime");
                    return;
                }
            }
            Console.WriteLine("Number is prime");
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You entered letter or symbol!");
        }

    }
}