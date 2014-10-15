using System;

class Task10SumAccuracy
{
    static void Main(string[] args)
    {
        decimal sequenceSum, previousSum ; // Using decimal values for bigger precision
        sequenceSum = 1; // First member which is 1
        int counter = 2;

        do
        {
            previousSum = sequenceSum;

            if (counter % 2 == 0) // Every even number
            {
                sequenceSum += (1.0m / counter);
                counter++;
            }
            else
            {
                sequenceSum -= (1.0m / counter); // Every odd number
                counter++;
            }
        }
        while(Math.Abs(sequenceSum-previousSum) > 0.001m);

        Console.WriteLine("The sum is: " + sequenceSum); // Printing the sum
    }
}