using System;

//Write a program to convert decimal numbers to their hexadecimal representation.

class Task03DecimalToHex
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine()); 

        // Converting by using ToString method and ToUpper() to show capital letter
        Console.WriteLine("Your decimal number in hexadecimal format looks like this: " + Convert.ToString(decimalNumber, 16).ToUpper());
    }
}