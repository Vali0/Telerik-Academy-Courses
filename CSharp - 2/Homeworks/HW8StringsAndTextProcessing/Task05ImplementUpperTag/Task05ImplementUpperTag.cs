using System;
using System.Text.RegularExpressions;

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> 
//to uppercase. The tags cannot be nested.

class Task05ImplementUpperTag
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your text(single line): ");
        string text = Console.ReadLine();

        int index = text.IndexOf("<upcase>"); // Getting index of oppening tag
        int endIndex = text.IndexOf("</upcase>"); // Getting index of closing tag

        // loop for all other tags in the text
        while (index != -1)
        {
            string toUp = text.Substring(index + 8, endIndex - index - 8); // Get the text between tags

            text = text.Replace(toUp, toUp.ToUpper()); // Replacing the text between tags with upper text

            endIndex = text.IndexOf("</upcase>", endIndex + 1);
            index = text.IndexOf("<upcase>", index + 1);
        }

        text = Regex.Replace(text, @"<upcase>|</upcase>", "");
        Console.WriteLine(text);
    }
}