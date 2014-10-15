using System;

/*You are given an array of strings. Write a method that sorts the array by the length 
* of its elements (the number of characters composing them).*/

class Task05SortingStringsByLength
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of your string array: ");
        string[] arrayOfStrings = new string[int.Parse(Console.ReadLine())];
        
        Console.WriteLine("Initialize your array: ");
        for (int i = 0; i < arrayOfStrings.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            arrayOfStrings[i] = Console.ReadLine();
        }

        // I use ordinary selection sort for this task. The tricky part is to get each cell length not the value.
        for (int i = 0; i < arrayOfStrings.Length - 1; i++)
        {
            for (int j = i + 1; j < arrayOfStrings.Length; j++)
            {
                if (arrayOfStrings[i].Length > arrayOfStrings[j].Length)
                {
                    string temp = arrayOfStrings[i];
                    arrayOfStrings[i] = arrayOfStrings[j];
                    arrayOfStrings[j] = temp;
                }
            }
        }
        //Printing the sorted array
        Console.WriteLine("\nSorted array is: ");
        foreach (var item in arrayOfStrings)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine(); // New line for prompt output
    }
}