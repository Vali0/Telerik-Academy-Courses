using System;

class Task01PrintingNNumbers
{
    static void Main(string[] args)
    {
        int loopLimit = 0;
        Console.WriteLine("Enter how many numbers you want to print: ");
        loopLimit = int.Parse(Console.ReadLine()); // Reading how many numbers will be printed
        for (int i = 1; i <= loopLimit; i++)
            Console.WriteLine(i); // Printing each number
    }
}