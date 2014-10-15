using System;

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

class Task11PrintNumberInDifferentWays
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your number: ");
        int number = int.Parse(Console.ReadLine());

        // Using simple format output
        Console.WriteLine("Decimal format: {0:D}", number);
        Console.WriteLine("Hexadecimal format: {0:X}", number);
        Console.WriteLine("Percentage format: {0:P}", number);
        Console.WriteLine("Scientific notation: {0:E}", number);
    }
}