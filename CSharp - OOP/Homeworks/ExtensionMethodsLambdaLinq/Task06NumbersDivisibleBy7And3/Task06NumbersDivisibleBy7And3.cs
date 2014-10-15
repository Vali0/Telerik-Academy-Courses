using System;
using System.Linq;

// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
// Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.


class Task06NumbersDivisibleBy7And3
{
    private const int Size = 100;

    static void Main(string[] args)
    {
        // Initialize the array
        int[] numbers = new int[Size];
        for (int i = 0; i < Size; i++)
        {
            numbers[i] = i;
        }

        var divisibleNumbersLambda = numbers.Where(x => x % 3 == 0 && x % 7 == 0); // Using lambda expression to filter the data

        Console.WriteLine("With lambda:");
        foreach (var item in divisibleNumbersLambda)
        {
            Console.WriteLine(item);
        }

        // Using Linq expression to filter the data
        var divisibleNumbersLinq = from num in numbers
                                   where num % 3 == 0 && num % 7 == 0
                                   select num;

        Console.WriteLine("With Linq:");
        foreach (var item in divisibleNumbersLinq)
        {
            Console.WriteLine(item);
        }
    }
}