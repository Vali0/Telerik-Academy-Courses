using System;

//Write a program to convert binary numbers to their decimal representation.

class Task02BinaryToDecimal
{
    static void Main(string[] args)
    {
        string binaryNumber = null;
        Console.WriteLine("Enter your binary representation of the number: ");
        binaryNumber = Console.ReadLine(); 

        // Converting by using ToInt32 method
        Console.WriteLine("Your binary number in decimal format is: " + Convert.ToInt32(binaryNumber, 2));
    }
}