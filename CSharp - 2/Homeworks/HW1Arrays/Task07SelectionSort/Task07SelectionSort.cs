using System;

class Task07SelectionSort
{
    /* Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
    * Use the "selection sort" algorithm: Find the smallest element, move it at the first position,
    * find the smallest from the rest, move it at the second position, etc.*/
    static void Main(string[] args)
    {
        int arraySize = 0;
        Console.WriteLine("Enter your array size: ");
        arraySize = int.Parse(Console.ReadLine());
        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}]= ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        // Selection sort algorithm
        for (int i = 0; i < arraySize - 1; i++)
        {
            for (int j = i + 1; j < arraySize; j++)
            {
                if (array[i] > array[j])
                {
                    //Using bitwise operations for better speed and less memory (don't need temp variable)
                    array[i] ^= array[j];
                    array[j] ^= array[i];
                    array[i] ^= array[j];
                }
            }
        }
        foreach (var item in array)
            Console.Write(item + " ");
    }
}