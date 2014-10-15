using System;

/* Write a method that returns the last digit of given integer as an English word. 
* Examples: 512 -?> "two", 1024 -> "four", 12309 -> "nine".*/

class Task03LastDigitName
{
    static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter your number: ");
        number = int.Parse(Console.ReadLine());
        GetDigit(number); // Calling the method
    }

    static void GetDigit(int number)
    {
        if (number / 10 == 0) // Check the length of the number. If it is a digit - printing it
        {
            Name(number); // Calling method which contains switch statement
        }
        else
        {
            Name(number % 10);  // Calling method which contains switch statement with last digit of the number
        }
    }

    static void Name(int digit)
    {
        switch(digit) // switch statement for printing digit name
        {
            case 0:
                Console.WriteLine("zero");
                break;
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            case 4:
                Console.WriteLine("four");
                break;
            case 5:
                Console.WriteLine("five");
                break;
            case 6:
                Console.WriteLine("six");
                break;
            case 7:
                Console.WriteLine("seven");
                break;
            case 8:
                Console.WriteLine("eight");
                break;
            case 9:
                Console.WriteLine("nine");
                break;
            default:
                Console.WriteLine("Some kind of error");
                break;
        }
    }
}