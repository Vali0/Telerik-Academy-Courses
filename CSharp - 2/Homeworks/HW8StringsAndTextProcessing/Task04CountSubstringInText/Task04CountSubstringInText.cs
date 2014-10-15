using System;
using System.Text.RegularExpressions;

//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

class Task04CountSubstringInText
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your text (single line): ");
        string text = Console.ReadLine();
        Console.WriteLine("Enter word/substring to search: ");
        string word = Console.ReadLine();
        int counter = 0;

        counter = Regex.Matches(text, word, RegexOptions.IgnoreCase).Count; // Using regex and IgnoreCase for case insensitive search
        Console.WriteLine("There is {0} occurrences of word \"{1}\"", counter, word);
    }
}