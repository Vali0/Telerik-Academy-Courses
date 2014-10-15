using System;
using System.Numerics;

//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. 
//Example: string = "43 68 9 23 318" -> result = 461

class Task06SumASequenceOfInts
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your sequence of integers(separated by ' '): ");
        String sequence = Console.ReadLine(); // Reading your sequence

        SumClass obj = new SumClass(sequence);

        BigInteger sum = 0;
        sum = obj.SplitSequence(); // Call the method from the other class

        Console.WriteLine("The sum of your sequence is: " + sum);
    }
}