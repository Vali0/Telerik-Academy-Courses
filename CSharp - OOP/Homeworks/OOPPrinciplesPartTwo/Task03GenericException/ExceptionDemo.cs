using System;

/*
Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
*/
class ExceptionDemo
{
    private static readonly string dateFormat = "d.M.yyyy"; // just changing format of printing

    static void Main(string[] args)
    {
        // Define bounds
        int start = 1;
        int end = 100;

        Console.WriteLine("Enter your integer number: ");
        int number = int.Parse(Console.ReadLine());
        try
        {
            CheckInteger(number, start, end); // Call method
            Console.WriteLine("In bounds"); // If there is no exception do smth...
        }
        catch (InvalidRangeException<int> ire)
        {
            Console.WriteLine("{0}\nRange: [{1} - {2}]", ire.Message, ire.Start, ire.End); // Print exception information
        }

        // Define bounds
        DateTime startDate = new DateTime(1980, 1, 1);
        DateTime endDate = new DateTime(2013,12, 31);
        
        Console.WriteLine("Enter your date in range [{0} - {1}]: ",
            startDate.ToString(dateFormat), endDate.ToString(dateFormat));
        DateTime myDate = DateTime.Parse(Console.ReadLine());

        try
        {
            CheckDate(myDate, startDate, endDate); // Call method
            Console.WriteLine("In bounds"); // If there is no exception do smth...
        }
        catch (InvalidRangeException<DateTime> ire)
        {
            Console.WriteLine("{0}\nRange: [{1} - {2}]", ire.Message, ire.Start, ire.End);  // Print exception information
        }
    }

    // Methods that just check bounds. And if the input is out of them throw an exception
    private static void CheckInteger(int number, int start, int end)
    {
        if (number < start || number > end)
        {
            throw new InvalidRangeException<int>("Integer is out of bounds!", start, end);
        }
    }

    private static void CheckDate(DateTime myDate, DateTime startDate, DateTime endDate)
    {
        if (myDate < startDate || myDate > endDate)
        {
            throw new InvalidRangeException<DateTime>("Date is out of bounds!", startDate, endDate);
        }
    }
}