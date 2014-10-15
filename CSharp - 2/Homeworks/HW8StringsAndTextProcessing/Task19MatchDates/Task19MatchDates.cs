using System;
using System.Globalization;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.

class Task19MatchDates
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your text with dates: ");
        string text = Console.ReadLine();

        string datePattern = @"\b([0-9]{2}).([0-9]{2}).([0-9]{4})\b";

        Regex rx = new Regex(datePattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        MatchCollection matches = rx.Matches(text);

        DateTime date;

        foreach (Match match in matches)
        {
            if (DateTime.TryParseExact(match.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern)); // Formatting the output
        }
    }
}