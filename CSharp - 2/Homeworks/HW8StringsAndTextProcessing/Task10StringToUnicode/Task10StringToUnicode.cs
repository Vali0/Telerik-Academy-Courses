using System;

//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.

class Task10StringToUnicode
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your text: ");
        string text = Console.ReadLine();

        foreach (char item in text)
        {
            Console.Write("\\u{0:X4}", (int)item); // Converting the input to unicode
        }
        Console.WriteLine();
    }
}