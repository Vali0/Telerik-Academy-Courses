using System;
using System.Linq;

/*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
* Use variable number of arguments.*/

class Task14SecondComplexProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("The minimal element of the sequence is: " + MinimalElement(1, 2, 3, 4));
        Console.WriteLine("The maximal element of the sequence is: " + MaximalElement(1, 2, 3, 4, 5, 6));
        Console.WriteLine("The average of the sequence is: " + AverageSum(1, 2, 3));
        Console.WriteLine("The product of the sequence is: " + Product(-1, 2, 3, 4, 8));
    }

    // Using params for undifined number of parameters and System.Linq for the most of operations
    static int MinimalElement(params int[] input)
    {
        return input.Min();
    }

    static int MaximalElement(params int[] input)
    {
        return input.Max();
    }
    
    static double AverageSum(params int[] input)
    {
        return input.Average();
    }

    // Simple multiplication
    static int Product(params int[] input)
    {
        int result = 1;
        for (int i = 0; i < input.Length; i++)
        {
            result *= input[i];
        }
        return result;
    }
}