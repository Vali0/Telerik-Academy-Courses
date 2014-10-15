using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks.

class Task09ForbiddenWords
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your text: ");
        string text = Console.ReadLine();
        List<string> words = new List<string>(); // List for forbidden words

        Console.WriteLine("\nEnter your forbidden words(type \"end\" for exit): ");
        while (true)
        {
            string singleWord = Console.ReadLine();
            if (singleWord != "end")
            {
                words.Add(singleWord);
            }
            else
            {
                break;
            }
        }
        
        for (int i = 0; i < words.Count; i++)
        {
            text = Regex.Replace(text, @"\b" + words[i] + @"\b", new String('*', words[i].Length)); // Replacing word forbidden word length
        }

        Console.WriteLine("\nAfter replacising forbidden words your text looks like that: \n" + text);
    }
}