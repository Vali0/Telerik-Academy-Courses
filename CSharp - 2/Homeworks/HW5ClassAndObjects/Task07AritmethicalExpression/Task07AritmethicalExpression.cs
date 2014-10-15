using System;
using System.Globalization;
using System.Threading;

//  *Write a program that calculates the value of given arithmetical expression. 
//  The expression can contain the following elements only:
//  Real numbers, e.g. 5, 18.33, 3.14159, 12.6
//  Arithmetic operators: +, -, *, / (standard priorities)
//  Mathematical functions: ln(x), sqrt(x), pow(x,y)
//  Brackets (for changing the default priorities)

//                          SOURCES
// Shunting yard algorithm: http://en.wikipedia.org/wiki/Shunting-yard_algorithm
// Reverse Polish Notation: http://en.wikipedia.org/wiki/Reverse_Polish_notation
// Little introduction to stack, queue,lists and information about algorithms in the taks: http://www.youtube.com/watch?v=a6wOX5zjyIQ
// Writing the program: http://www.youtube.com/watch?v=Flyvw7tmEBg
// In the video is very well explained what is done in this taks.
// I use logic from there, just separate program into different classes and make few permission changes.

public class ExpressionCalculator
{
    public static void Main()
    {
        PutInvariantCulture();
        Console.WriteLine("Enter your eqation: ");
        string input = Console.ReadLine().Trim(); // Trim input just for sure

        try
        {
            string trimmedInput = input.Replace(" ", null); // Replace all white-spaces with null value
            var separatedTokens = SeparateInput.SeparateTokens(trimmedInput); // Separate your input by tokens
            var reversePolishNotation = ShuntingYard.ConvertToReversePolishNotation(separatedTokens); // Convert those tokens into Reverse Polish Notation
            var finalResult = CalculateRPNEquation.GetResultFromRPN(reversePolishNotation); // Calculating the equation
            Console.WriteLine("The result of equation is: " + finalResult);
        }
        catch (ArgumentException exeption)
        {
            Console.WriteLine(exeption.Message);
        }
    }
    
    public static void PutInvariantCulture()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; // To make sure that '.' is dot and ',' is comma
    }
}