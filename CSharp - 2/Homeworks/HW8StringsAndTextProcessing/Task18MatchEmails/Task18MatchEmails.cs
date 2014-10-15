using System;
using System.Text.RegularExpressions;

//Write a program for extracting all email addresses from given text.
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

class Task18MatchEmails
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your text with emails: ");
        string text = Console.ReadLine();

        // I found that pattern in internet... don't ask me about it :) 
        string emailPattern =
                             @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@" +
                             @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\." +
                             @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|" +
                             @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";

        Regex rx = new Regex(emailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase); 
        MatchCollection matches = rx.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value.ToString()); // Printing the emails
        }
    }
}