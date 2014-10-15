using System;

/*Write a program that reads two integer numbers N and K and an array of N elements from the console. 
Find in the array those K elements that have maximal sum.*/

class Task06KMaxSum
{
    static void Main(string[] args)
    {
        int sizeOfArray, kElements;
        int sum = 0;
        Console.WriteLine("Enter array size: ");
        sizeOfArray = int.Parse(Console.ReadLine());
        int[] array = new int[sizeOfArray];

        Console.WriteLine("Initialize your array");
        for (int i = 0; i < sizeOfArray; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enyer your K elements: ");
        kElements = int.Parse(Console.ReadLine());

        Array.Sort(array); // Making biggest numbers at the end of the array
        for (int i = sizeOfArray - 1; i >= sizeOfArray - kElements; i--)
        {
            sum += array[i]; // Summing the last K elements
        }
        Console.WriteLine("The max sum of {0} elements is: {1}", kElements, sum);
    }
}