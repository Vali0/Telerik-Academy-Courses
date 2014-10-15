using System;

/*Write a program, that reads from the console an array of N integers and an integer K, 
* sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. */

class Task04BinarySearch
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your array size: ");
        int[] array = new int[int.Parse(Console.ReadLine())];
        Random rand = new Random(); // Random numbers to fill the matrix
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-10, 10);
            //array[i] = int.Parse(Console.ReadLine()); // If you want manual input
        }
        
        Array.Sort(array); // Sorting the array

        Console.WriteLine("Your array looks like that: ");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Enter number(K) that you want to search: ");
        int number = int.Parse(Console.ReadLine());
        int index = Array.BinarySearch(array, number); // Taking the index of the inputed number in the sorted array
        if (index > 0 && index < array.Length) // If the index exist
        {
            Console.WriteLine("The largest number is <=K: " + array[index]); 
        }
        else // Else program will return index with negative value bigger than array length
        {
            int i = array.Length - 1; // getting the last index
            while (true) 
            {
                if (array[i] < number) // First number which is less than K
                {
                    Console.WriteLine("The largest number is which is <=K: " + array[i]);
                    break; // Stops the loop
                }
                i--;
            }
        }
    }
}