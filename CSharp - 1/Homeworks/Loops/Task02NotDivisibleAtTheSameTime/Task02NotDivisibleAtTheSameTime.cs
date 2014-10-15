using System;

class Task02NotDivisibleAtTheSameTime
{
    static void Main(string[] args)
    {
        int loopLimit = 0;
        Console.WriteLine("Enter how many numbers you want to check: ");
        loopLimit = int.Parse(Console.ReadLine()); // Reading how many numbers will be checked
        for (int i = 1; i <= loopLimit; i++)
            if (!(i % 3 == 0 && i % 7 == 0)) // if they are not divisible by 3 and 7 at the same time
                Console.WriteLine(i); // Printing those
    }
}