using System;

class WorkdaysCalculator
{
    public static int WorkDays(string[] startDate, string[] endDate)
    {
        // Getting each parameter in different variable
        byte startDay = byte.Parse(startDate[0]);
        byte startMonth = byte.Parse(startDate[1]);
        ushort startYear = ushort.Parse(startDate[2]);

        byte endDay = byte.Parse(endDate[0]);
        byte endMonth = byte.Parse(endDate[1]);
        ushort endYear = ushort.Parse(endDate[2]);
        
        DateTime start = new DateTime(startYear, startMonth, startDay);
        DateTime end = new DateTime(endYear, endMonth, endDay); // Making the end date

        int workDaysCounter = 0;

        do
        {
            workDaysCounter++;
            start = start.AddDays(1); // Adding the next day
        }
        while (end.DayOfYear + 1 != start.DayOfYear || end.Year != start.Year);

        return workDaysCounter; // Returining the value to Main method
    }
}