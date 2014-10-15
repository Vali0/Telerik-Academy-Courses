using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//Write a program that reads a string from the console and prints all different letters in the string 
//along with information how many times each letter is found. 

class Task21DifferentLetters
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your text: ");
        string text = Console.ReadLine();
        Dictionary<string, int> dictionary = new Dictionary<string, int>(); // I use dictionary to keep information about letters
        List<string> letters = new List<string>();
        
        foreach (Match item in Regex.Matches(text, "[a-zA-Z]")) // Matching all letters
        {
            letters.Add(item.Value); // Adding each letter to the list(only letters - no symbols no whitespaceses)
        }

        for (int i = 0; i < letters.Count; i++)
        {
            if (!dictionary.ContainsKey(letters[i])) // If we don't have that letter remember it to dictionary
            {
                dictionary.Add(letters[i], 1);
            }
            else
            {
                dictionary[letters[i]] += 1; // If we have it increase its value
            }
        }

        // Printing the dictionary
        foreach (var pair in dictionary)
        {
            Console.WriteLine("{0} -> {1}", pair.Key, pair.Value); 
        }
    }
}