using System;
using System.Numerics;

class Task13HowManyZerosHaveInTheEnd
{
    static void Main(string[] args)
    {
        try
        {

            BigInteger number = 0u; // BigInteger type because I don't know how big is your imagination :)
            byte counter = 0;
            Console.WriteLine("Enter your number: ");
            number = BigInteger.Parse(Console.ReadLine());

            //Simple while loop ends when saw number different than 0
            while (number % 10 == 0)
            {
                number = (BigInteger)(number / 10);
                counter++; // Just counting the zeroes
            }
            Console.WriteLine("There is {0} zeroes in the end of the {1}", counter, number * (uint)Math.Pow(10, counter)); // Printing how many zeroes have the inputed number
            // Math.Pow(10,counter) because I use the same variable in calculations and I'll print it without zeroes. Can be made by using another variable for output with inputed value of number or just to not print it.
        }
        catch (FormatException)
        {
            Console.WriteLine("You entered letter or symbol!");
        }
    }
}