using System;

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

class Task01SquareRoot
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter your positive integer number: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(number));
        }
        catch (System.OverflowException)
        {
            Console.WriteLine("Negative value!");
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Invalid input (probably floating point number or letters)!");
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}