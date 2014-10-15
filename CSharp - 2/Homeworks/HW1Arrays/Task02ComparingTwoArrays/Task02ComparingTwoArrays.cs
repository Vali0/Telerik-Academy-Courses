using System;

class Task02ComparingTwoArrays
{
    /*
    * Write a program that reads two arrays from the console and compares them element by element.
    */
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of your arrays");
        int size = int.Parse(Console.ReadLine()); // Entering the size of the arrays
        int[,] arrays = new int[2, size]; // I use one two dimentional array (could be done with two one dimentional arrays)

        Console.WriteLine("Initialize first array with size: " + size);
        for (int i = 0; i < size; i++)
        {
            arrays[0, i] = int.Parse(Console.ReadLine()); //Initializing the first array
        }

        Console.WriteLine("Initialize second array with size: " + size);
        for (int i = 0; i < size; i++)
        {
            arrays[1, i] = int.Parse(Console.ReadLine()); //Initializing the second array
        }

        for (int i = 0; i < size; i++)
        {
            if (arrays[0, i] != arrays[1, i]) //Comparing elements of the two dimentional array
            {
                Console.WriteLine("Two arrays aren't equal!"); 
                return; // If they aren't equal printing appropriate message and stopping the program
            }
        }
        Console.WriteLine("Two arrays are equal!"); //If they are equal
    }
}