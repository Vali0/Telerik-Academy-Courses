using System;

class Task08PrintingNNumbers
{
    static void Main(string[] args)
    {
        int number = 0;
        Console.WriteLine("Enter your number: ");
        number = int.Parse(Console.ReadLine()); // Right border of the loop
        Console.WriteLine(); // Just new line

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
