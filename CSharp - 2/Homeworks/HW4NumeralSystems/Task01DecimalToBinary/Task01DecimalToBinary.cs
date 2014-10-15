using System;

//Write a program to convert decimal numbers to their binary representation.

class Task01DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your number decimal representation: ");
        int number = int.Parse(Console.ReadLine()) ; // Reading your input
        
        // Simple convertion to binary using ToString method and Pading the number for better view
        Console.WriteLine("Binary representation of your number is: " + Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}