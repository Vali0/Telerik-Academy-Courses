using System;
using System.Collections.Generic;

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary. 
//Sample dictionary:
//.NET – platform for applications from Microsoft
//CLR – managed execution environment for .NET
//namespace – hierarchical organization of classes

class Task14Dictionary
{
    static void Main(string[] args)
    {
        // Creating a dictionary
        Dictionary<string, String> dictionary = new Dictionary<string, string>();

        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");

        Console.WriteLine("Enter your word: ");
        string word = Console.ReadLine();

        // Searching for the word in the dictionary
        if (dictionary.ContainsKey(word))
        {
            Console.WriteLine("{0} - {1}", word, dictionary[word]);
        }
        else
        {
            Console.WriteLine("No such word!");
        }
    }
}