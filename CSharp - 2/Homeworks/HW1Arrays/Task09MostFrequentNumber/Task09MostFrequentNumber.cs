using System;
using System.Linq;

class Task09MostFrequentNumber
{
    /* Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times) */


    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of your array: ");
        int size = int.Parse(Console.ReadLine()); //Getting array size
        int[] array = new int[size];
        Console.WriteLine("Initialize your array");

        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine()); //Initializing the array
        }

        // First link in google :)
        // http://stackoverflow.com/questions/2655759/how-to-get-the-most-common-value-in-an-int-array-c
        // And little bit info for Linq library: http://msdn.microsoft.com/en-us/library/vstudio/bb397933.aspx if you want to ofcourse

        var query = (from item in array
                     group item by item into g
                     orderby g.Count() descending
                     select new { Value = g.Key, Count = g.Count() }).First();
        Console.WriteLine(query);
    }
}