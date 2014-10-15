using System;
using System.Globalization;

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time
//after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

class Task17DateAndTime
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter date and time in format day.month.year hour:minute:second");
        string dateTime = Console.ReadLine(); // Read date and time as string
        try
        {
            DateTime dTime = DateTime.ParseExact(dateTime, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture); // Creating DateTime object with our input

            dTime = dTime.AddHours(6.5); // Adding 6 hours and 30 minutes

            Console.WriteLine("date is {0} and time is {1}", dTime.ToString("dddd", new CultureInfo("bg-BG")), dTime); // Printing the date with format of Bulgariant Culture
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Wrong input.\n" + fe.Message);
        }
    }
}