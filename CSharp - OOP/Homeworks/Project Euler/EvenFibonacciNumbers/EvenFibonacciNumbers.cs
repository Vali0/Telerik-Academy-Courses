using System;
using System.Collections.Generic;
using System.Linq;

class EvenFibonacciNumbers
{
    static void Main(string[] args)
    {
        long firstNumber = 0; // First member of the sequence
        long secondNumber = 1; // Second member of the sequence
        long temp;

        // Printing them outside of the loop
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);

        while (temp < 4000000)
        {
            Console.WriteLine(firstNumber + secondNumber); // Printing the next member of the sequence
            temp = secondNumber;
            secondNumber = firstNumber + secondNumber;
            firstNumber = temp;
        }
    }
}