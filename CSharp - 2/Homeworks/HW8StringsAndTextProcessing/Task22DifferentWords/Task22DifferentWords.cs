using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//Write a program that reads a string from the console and lists all different words in the string 
//along with information how many times each word is found.

class Task22DifferentWords
{
    static void Main(string[] args)
    {
        // Simmilar to the previous one. But this time we will remember whole words(ONLY WORDS)
        Console.WriteLine("Enter your text: ");
        string text = Console.ReadLine();
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        List<string> words = new List<string>();

        foreach (Match item in Regex.Matches(text, @"\b([a-zA-Z])+\b")) // Remember only words
        {
            words.Add(item.Value);
        }

        for (int i = 0; i < words.Count; i++)
        {
            if (!dictionary.ContainsKey(words[i]))
            {
                dictionary.Add(words[i], 1);
            }
            else
            {
                dictionary[words[i]] += 1;
            }
        }
        foreach (var pair in dictionary)
        {
            Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
        }
    }
}