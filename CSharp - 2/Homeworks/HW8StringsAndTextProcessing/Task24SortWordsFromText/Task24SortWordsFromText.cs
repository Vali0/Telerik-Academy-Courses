using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

class Task24SortWordsFromText
{
    static void Main(string[] args)
    {
        // Very simmilar to the previous two

        Console.WriteLine("Enter your string: ");
        string text = Console.ReadLine();
        List<string> words = new List<string>();

        foreach (Match item in Regex.Matches(text, @"\b([a-zA-Z])+\b")) 
        {
            words.Add(item.Value); // Put all words into the list
        }

        words.Sort(); // Sorting them

        // Printing them sorted
        foreach (string word in words)
            Console.WriteLine(word);
    }
}