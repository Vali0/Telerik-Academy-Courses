using System;

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 

class Task16CountDays
{
    static void Main(string[] args)
    {
        // This is how I understand the program!!!
        // In task its written dates between 27.02.2006 and 03.03.2004 and the answer is 4
        // For me this isn't correct date - start date must be less than end date. This could be fixed easly with simple changing of values
        // But difference between this two dates isn't 4!!! We have difference in years which make days much bigger!
        try
        {
            String[] startDate, endDate;
           
            // do-while statemant for correct input. Date that is earlyer than today date
            do
            {
                Console.WriteLine("Enter start date(dd.MM.yyyy)): ");
                startDate = Console.ReadLine().Split('.');
                Console.WriteLine("Enter end date(dd.MM.yyyy)): ");
                endDate = Console.ReadLine().Split('.'); // Splitting the input.
            }
            while (Convert.ToByte(endDate[0]) < Convert.ToByte(startDate[0]) && Convert.ToByte(endDate[1]) < Convert.ToByte(startDate[1]) && Convert.ToInt16(endDate[2]) < Convert.ToInt16(startDate[2]));

            int workDays = WorkdaysCalculator.WorkDays(startDate, endDate); // Passing today and end date to method

            Console.WriteLine("There is {0} days.", workDays); // Printing the result
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Unfully date!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Wrong format must be (dd.MM.yyyy)");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid date");
        }
    }
}