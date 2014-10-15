using System;

    class WorkdaysCalculator
    {
        public static int WorkDays(DateTime today, string[] endDate)
        {
            // Getting each parameter in different variable
            byte day = byte.Parse(endDate[0]);
            byte month = byte.Parse(endDate[1]);
            ushort year = ushort.Parse(endDate[2]);

            DateTime end = new DateTime(year, month, day); // Making the end date

            int workDaysCounter = 0;

            do
            {
                // if the day is different than saturday and sunday
                if (Convert.ToString(today.DayOfWeek) != "Saturday" && Convert.ToString(today.DayOfWeek) != "Sunday")
                {
                    workDaysCounter++;
                }
                today = today.AddDays(1); // Adding the next day
            }
            while (end.DayOfYear + 1 != today.DayOfYear || end.Year != today.Year);

            return workDaysCounter; // Returining the value to Main method
        }
    }
