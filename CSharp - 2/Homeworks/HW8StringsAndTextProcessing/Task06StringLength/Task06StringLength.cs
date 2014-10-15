using System;

//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//Print the result string into the console.

class Task06StringLength
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your string: "); // Read the string
        string text = Console.ReadLine();

        if (text.Length == 20)
        {
            Console.WriteLine(text);
        }
        else if (text.Length < 20)
        {
            Console.WriteLine(text.PadRight(20, '*')); // If our string is less than 20 symbols we Pad it Right
        }
        else
        {
            Console.WriteLine(text.Substring(0, 20)); // If it is bigger than 20 get exactly 20 symbols of it
        }
    }
}