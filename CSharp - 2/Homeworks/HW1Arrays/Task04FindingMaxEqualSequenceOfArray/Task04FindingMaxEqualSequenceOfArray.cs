﻿using System;
using System.Collections.Generic;

//Write a program that finds the maximal sequence of equal elements in an array.
// Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

class Task04FindingMaxEqualSequenceOfArray
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of your array: ");
        int size = int.Parse(Console.ReadLine()); //Getting array size
        int[] array = new int[size];
        List<int> list = new List<int>(); // List for sequence elements
        Console.WriteLine("Initialize your array");
        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine()); //Initializing the array
        }
        int sequenceCounter = 1; // Counter for max length
        int oldSequenceCounter = 1; // Counter for temp length
        int start = 0; // Where starts the sequence with max legnth
        int oldStart = 0; // Temp variable for start

        for (int i = 0; i < size - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                oldSequenceCounter++;
                if (oldSequenceCounter > sequenceCounter) // If the new sequence length is bigger than last
                {
                    sequenceCounter = oldSequenceCounter;
                    start = oldStart;
                }
            }
            else
            {
                oldSequenceCounter = 1;
                oldStart = i + 1;
            }
        }
        Console.WriteLine("Maximal length is: " + sequenceCounter);
        for (int i = start; i < start + sequenceCounter; i++)
        {
            list.Add(array[i]); // Putting the biggest sequence values
        }
        for (int i = 0; i < list.Count; i++) // Loop for printing them
        {
            if (i != list.Count - 1)
                Console.Write(list[i] + ", ");
            else
                Console.WriteLine(list[i]);
        }
    }
}