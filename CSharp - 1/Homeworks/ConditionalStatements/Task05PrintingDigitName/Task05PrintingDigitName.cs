using System;

class Task05PrintingDigitName
{
    static void Main(string[] args)
    {
        try
        {
            // Defining the digit
            byte digit = 0;

            // Inputing our digit through console
            Console.WriteLine("Enter your digit: ");
            digit = byte.Parse(Console.ReadLine());

            // Switch statemant print digit name
            switch (digit)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                default: Console.WriteLine("You didn't entered a digit!"); // If you entered a number (number is made by digits)
                    break;
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You entered letter or symbol!");
        }
    }
}
