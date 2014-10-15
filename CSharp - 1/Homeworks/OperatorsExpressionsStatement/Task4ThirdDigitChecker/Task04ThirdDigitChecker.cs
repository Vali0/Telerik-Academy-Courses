using System;

class Task04ThirdDigitChecker
{
    static void Main(string[] args)
    {
        int intNumber = 0;
        Console.WriteLine("Enter a number: ");
        intNumber = int.Parse(Console.ReadLine());
        intNumber /= 100; // Making third digit from right to left last!
        Console.WriteLine(intNumber % 10 == 7); // Checking is the last digit in the new number 7
    }
}
