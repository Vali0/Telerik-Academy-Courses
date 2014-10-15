using System;

class PrintingDateAndTime
{
    static void Main(string[] args)
    {
        DateTime time = DateTime.Now;              // Use current time
        string format = "HH:mm ddd d MMM yyyy";    // Use this format
        Console.WriteLine(time.ToString(format));  // Write to console
    }
}
