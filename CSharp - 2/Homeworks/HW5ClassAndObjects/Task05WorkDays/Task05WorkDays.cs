using System;

//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays
//specified preliminary as array.

class Task05WorkDays
{
    static void Main(string[] args)
    {
        try
        {
            String[] endDate;
            DateTime today = DateTime.Today; // Getting today date. Date that is on the computer.
            Console.WriteLine("Today is: " + today.ToString("dd/MM/yyyy"));

            // do-while statemant for correct input. Date that is earlyer than today date
            do
            {
                Console.WriteLine("Enter end date(dd/MM/yyyy)): ");
                endDate = Console.ReadLine().Split('/'); // Splitting the input.
            }
            while (Convert.ToByte(endDate[0]) < today.Day || Convert.ToByte(endDate[1]) < today.Month || Convert.ToInt16(endDate[2]) < today.Year);

            int workDays = WorkdaysCalculator.WorkDays(today, endDate); // Passing today and end date to method

            Console.WriteLine("There is {0} work days including today and given.", workDays); // Printing the result
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Unfully date!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Wrong format must be (dd/MM/yyyy)");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid date");
        }
    }
}