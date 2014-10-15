using System;
using System.Numerics; // We need to remember a big nubers

class Task09FibonacciSequence
{
    static void Main(string[] args)
    {
        BigInteger firstNumber = 0; // First member of the sequence
        BigInteger secondNumber = 1; // Second member of the sequence
        BigInteger temp;

        // Printing them outside of the loop
        Console.WriteLine(firstNumber); 
        Console.WriteLine(secondNumber);

        for (int i = 1; i < 99; i++)
        {
            Console.WriteLine(firstNumber + secondNumber); // Printing the next member of the sequence
            temp = secondNumber;
            secondNumber = firstNumber + secondNumber;
            firstNumber = temp;
        }
    }
}

