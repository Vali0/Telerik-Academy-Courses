using System;
using System.Collections.Generic;

class Task18sortedArrayingAnArrayWithRemoving
{
    /*
    * * Write a program that reads an array of integers and removes from it a minimal number of elements
    * in such way that the remaining array is sortedArrayed in increasing order. Print the remaining sortedArrayed array.
    * Example:	{6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}
    */
    static void Main(string[] args)
    {
        Console.WriteLine("Enter how big will be your array: ");
        int[] array = new int[int.Parse(Console.ReadLine())];

        // Filling the array
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int length = (int)(Math.Pow(2, array.Length) - 1);
        List<int> sortedArray = new List<int>();
        List<int> tempElements = new List<int>();
        int minValue;
        int oldcounterer = 0;
        int counter = 0;

        for (int i = 0; i <= length; i++)
        {
            // check all combination in which the next number is bigger or equal to previous
            oldcounterer = 0;
            minValue = int.MinValue;
            
            for (int j = 0; j < array.Length; j++)
            {
                if ((((i >> j) & 1) == 1) && (minValue <= array[j]))
                {
                    minValue = array[j];
                    tempElements.Add(array[j]);
                    oldcounterer++;
                }
            }

            // check if the new combination is bigger than the previous
            if (oldcounterer > counter)
            {
                sortedArray.Clear();
                counter = oldcounterer;
                for (int j = 0; j < tempElements.Count; j++)
                {
                    sortedArray.Add(tempElements[j]);
                }
            }
            tempElements.Clear();
        }

        // Print the biggest combination
        for (int i = 0; i < sortedArray.Count; i++)
        {
            Console.Write(sortedArray[i] + " ");
        }
        Console.WriteLine();
    }
}