using System;

class Task10BonusScore
{
    static void Main(string[] args)
    {
        try
        {
            // Defining and initializing variables
            int input = 0;
            Console.WriteLine("Enter your digit: ");
            input = int.Parse(Console.ReadLine());
            
            switch (input)
            {
                case 1:
                case 2:
                case 3: input *= 10;
                    Console.WriteLine("After multiplication by '10' your digit is: " + input);
                    break;
                case 4:
                case 5:
                case 6: input *= 100;
                    Console.WriteLine("After multiplication by '100' your digit is: " + input);
                    break;
                case 7:
                case 8:
                case 9: input *= 1000;
                    Console.WriteLine("After multiplication by '1000' your digit is: " + input);
                    break;
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