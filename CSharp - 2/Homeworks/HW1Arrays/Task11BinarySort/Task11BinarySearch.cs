using System;

class Task11BinarySearch
{
    /*
     * Write a program that finds the index of given element in a sorted array of 
     * integers by using the binary search algorithm (find it in Wikipedia).
     */

    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of your array: ");
        int size = int.Parse(Console.ReadLine()); //Getting array size
        int[] array = new int[size];
        int element = 0;
        Console.WriteLine("Initialize your array");

        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine()); //Initializing the array
        }

        Array.Sort(array); // Sorting the array
        Console.WriteLine("Enter element which index you want to see in the sorted array: ");
        element = int.Parse(Console.ReadLine());
        int index = Array.BinarySearch(array, element);
        if(index != (-1)*(array.Length+1)) // If there is no element it will return the negative value of array length plus one
        Console.WriteLine("The index of elements {0} is: {1} (counting from '0')",element,index); 
        else
            Console.WriteLine("There is no {0} element in the array",element);
        // Little more examples here: http://www.dotnetperls.com/array-binarysearch
    }
}
