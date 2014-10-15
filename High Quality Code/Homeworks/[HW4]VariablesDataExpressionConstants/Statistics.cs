namespace Task02StatisticsRefactoring
{
    using System;
    using System.Linq;
	
	// Refactor the following code to apply variable usage and naming best practices:
	// I use here Linq functions. It's easy it's fast it's easy to read and understand.
    class Statistics
    {
        public void PrintStatistics(double[] numbers)
        {
            Console.WriteLine(FindMaxElement(numbers));
            Console.WriteLine(FindMinElement(numbers));
            Console.WriteLine(CalculateAverage(numbers));
        }

        public static double FindMaxElement(double[] numbers)
        {
            double maxElement = numbers.Max(); // Linq

            return maxElement;
        }

        public static double FindMinElement(double[] numbers)
        {
            double minElement = numbers.Min(); // Linq

            return minElement;
        }

        public static double CalculateAverage(double[] numbers)
        {
            double elementsSum = numbers.Sum(); // Linq
            int elementsCount = numbers.Length;
            double average = elementsSum / elementsCount;

            return average;
        }
    }
}