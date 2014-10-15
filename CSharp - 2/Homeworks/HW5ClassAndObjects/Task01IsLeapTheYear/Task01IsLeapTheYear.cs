using System;

//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

class Task01IsLeapTheYear
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your year: ");
        int year = int.Parse(Console.ReadLine());
        //bool isLeap = DateTime.IsLeapYear(year); //One row solution

        // My solution using exception
        try
        {
            DateTime date = new DateTime(year, 2, 29); // Make the date 29 february xxxx year. 
            //If it exist it will go on, if not will go to catch satement
            Console.WriteLine("This is is leap");
        }
        catch (System.ArgumentOutOfRangeException)
        {
            Console.WriteLine("This year is not a leap");
        }
    }
}