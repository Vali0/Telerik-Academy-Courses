using System;

class Task07GreatestOf5
{
    static void Main(string[] args)
    {
        double[] doubleArray = new double[5]; // I use an array for that task
        try
        {
            // Filling the array
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter {0} number: ", (i+1));
                doubleArray[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(doubleArray); // I use array sort becouse it is easy to do on that way
            Console.WriteLine("The greatest number is: " + doubleArray[4]); // After sorting the biggest number is on the top of the array
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You entered letter or symbol!");
        }
    }
}