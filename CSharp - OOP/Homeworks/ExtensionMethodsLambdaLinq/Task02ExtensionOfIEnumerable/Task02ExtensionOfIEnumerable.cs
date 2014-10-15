using System;

//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
//sum, product, min, max, average.

class Task02ExtensionOfIEnumerable
{
    private const int Size = 4;

    static void Main(string[] args)
    {
        // Initialize the array
        int[] numbers = new int[Size];

        for (int i = 0; i < Size; i++)
        {
            numbers[i] = i+1;
        }

        // Print the array
        Console.WriteLine("Your array looks like that: ");
        foreach (var item in numbers)
        {
            Console.Write(item+ " ");
        }

        // Call the extension methods. Not need an instance of the class because it is extension!
        Console.WriteLine();
        Console.WriteLine(numbers.Sum());
        Console.WriteLine(numbers.Product());
        Console.WriteLine(numbers.Min());
        Console.WriteLine(numbers.Max());
        Console.WriteLine(numbers.Average());
    }
}