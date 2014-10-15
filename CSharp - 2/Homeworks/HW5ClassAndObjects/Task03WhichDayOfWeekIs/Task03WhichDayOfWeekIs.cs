using System;

// Write a program that prints to the console which day of the week is today. Use System.DateTime.

class Task03WhichDayOfWeekIs
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Today; // Creating date object with values of computer date time specifications
        Console.Write(Convert.ToString(date.Day).PadLeft(2, '0') + " - "); // Converting it to string and padding it.
                                                                           // Because if it is 2 we want to print 02 on console
        Console.WriteLine(date.DayOfWeek); 
    }
}