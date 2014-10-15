using System;

//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample" -> "elpmas".

class Task02ReverseString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your word: ");
        string word = Console.ReadLine();
        char[] wordArray = word.ToCharArray(); // Convert input to array of chars

        Array.Reverse(wordArray); // Reverse the array

        foreach (var item in wordArray)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}