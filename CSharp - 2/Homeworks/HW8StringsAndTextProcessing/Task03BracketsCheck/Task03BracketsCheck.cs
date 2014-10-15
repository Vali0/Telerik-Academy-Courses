using System;
using System.Text.RegularExpressions;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

class Task03BracketsCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your expression: ");
        string expression = Console.ReadLine();

        int openBracket = 0;
        int closeBracket = 0;

        openBracket = Regex.Matches(expression, @"\(").Count; // Count oppening brackets
        closeBracket = Regex.Matches(expression, @"\)").Count; // Count closing brackets
        
        // Check number of brackets
        if (openBracket == closeBracket)
        {
            Console.WriteLine("Exxpression is correct");
        }
        else
        {
            Console.WriteLine("Expression is incorrect");
        }
    }
}