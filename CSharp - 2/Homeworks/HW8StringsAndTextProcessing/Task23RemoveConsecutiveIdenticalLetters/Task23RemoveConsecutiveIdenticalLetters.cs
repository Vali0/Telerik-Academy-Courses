using System;
using System.Text.RegularExpressions;

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".

class Task23RemoveConsecutiveIdenticalLetters
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your string: ");
        string text = Console.ReadLine();

        Console.WriteLine(Regex.Replace(text, @"(\w)\1+", "$1")); // Found it on internet
    }
}