using System;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

class Task20Palindromes
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your text: ");
        string text = Console.ReadLine();

        foreach (Match item in Regex.Matches(text, @"\w+")) // Matching the words
        {
            if (IsPalindrome(item.Value)) // Parsing each of them to he method
            {
                Console.WriteLine(item);
            }
        }
    }

    // I found this at internet too :)
    public static bool IsPalindrome(string item)
    {
        for (int i = 0; i < item.Length / 2; i++)
        {
            if (item[i] != item[item.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}