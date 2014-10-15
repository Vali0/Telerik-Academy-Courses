using System;

class Task01DeclaratingAndInitializingAnArray
{
    /*
    * Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
    * Print the obtained array on the console.
    */
    static void Main(string[] args)
    {
        int[] array = new int[20]; //Declarating the array with fixed size

        for (int i = 0; i < 20; i++)
        {
            array[i] = i * 5; // Initializing the array
        }
        foreach (var item in array)
            Console.WriteLine(item); // Printing each element of the array on single line
    }
}