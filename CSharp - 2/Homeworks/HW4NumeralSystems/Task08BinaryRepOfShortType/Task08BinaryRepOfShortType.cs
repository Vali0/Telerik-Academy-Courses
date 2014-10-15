using System;

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

class Task08BinaryRepOfShortType
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter yout 16 bit number(short type in C#): ");
            short byteNumber = short.Parse(Console.ReadLine());

            // Simple converting by using ToString method and PadLeft the binary number with 16 bits
            Console.WriteLine("Your short number in binary format looks like that: " + Convert.ToString(byteNumber, 2).PadLeft(16, '0'));
        }
        catch (System.OverflowException)
        {
            Console.WriteLine("Your number isn't short!");
        }
    }
}