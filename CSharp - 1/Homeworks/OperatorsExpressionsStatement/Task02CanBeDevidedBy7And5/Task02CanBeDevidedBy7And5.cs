using System;

class Task02CanBeDevidedBy7And5
{
    static void Main(string[] args)
    {
        int input = 0;
        try
        {
            Console.WriteLine("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            if (input % 7 == 0 && input % 5 == 0)
            {
                Console.WriteLine("The number {0} CAN be divided by '7' and '5' in the same time!", input);

            }
            else
                Console.WriteLine("The number {0} CAN'T be divided by '7' and '5' in the same time!", input);
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You entered a letter or symbol!");
        }
    }
}

