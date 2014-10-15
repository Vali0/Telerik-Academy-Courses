using System;

class Program
{
    static void Main(string[] args)
    {
        int[] date = new int[3];
        DateTime time;
        string format = "d.M.yyyy";

        do
        {
            //Console.WriteLine("Enter date of week");
            date[0] = int.Parse(Console.ReadLine());
        }
        while (date[0] < 1 || date[0] > 31);

        do
        {
           // Console.WriteLine("Enter the month");
            date[1] = int.Parse(Console.ReadLine());
        }
        while (date[1] < 1 || date[1] > 12);

        do
        {
            //Console.WriteLine("Enter the year");
            date[2] = int.Parse(Console.ReadLine());
        }
        while (date[2] < 2000 || date[2] > 2013);

        date[0]++;
        try
        {
            time = new DateTime(date[2], date[1], date[0]);
            Console.WriteLine(time.ToString(format));
        }
        catch (System.ArgumentOutOfRangeException)
        {
            try
            {
                date[0] = 1;
                date[1]++;
                time = new DateTime(date[2], date[1], date[0]);
                Console.WriteLine(time.ToString(format));
            }
            catch (System.ArgumentOutOfRangeException)
            {
                date[0] = 1;
                date[1] = 1;
                date[2]++;
                time = new DateTime(date[2], date[1], date[0]);
                Console.WriteLine(time.ToString(format));
            }
        }

    }
}