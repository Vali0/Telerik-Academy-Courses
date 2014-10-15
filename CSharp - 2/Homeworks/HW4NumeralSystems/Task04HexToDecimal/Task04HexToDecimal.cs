using System;

//Write a program to convert hexadecimal numbers to their decimal representation.

class Task04HexToDecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your hexadecimal number: ");
        string hexNumber = Console.ReadLine().ToUpper();

        // Converting by using ToInt32 method
        Console.WriteLine("Your hexadecimal number in decimal format looks like that: " + Convert.ToInt32(hexNumber, 16));
    }
}