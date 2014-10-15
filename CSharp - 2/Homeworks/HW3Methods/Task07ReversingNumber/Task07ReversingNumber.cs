using System;

//Write a method that reverses the digits of given decimal number. Example: 256 -> 652

class Task07ReversingNumber
{
    static void Main(string[] args)
    {
        decimal number = 0m;
        Console.WriteLine("Enter your decimal number: ");
        number = decimal.Parse(Console.ReadLine());
        String result = ReversingDecimal(number); // Using string representation of the decimal number
        Console.WriteLine(result); // printing the result
    }

    static string ReversingDecimal(decimal number)
    {
        string stringNumber = number.ToString(); // Converting decimal number to string
        char[] charOfTheNumber = stringNumber.ToCharArray(); // Converting string to array of chars
        Array.Reverse(charOfTheNumber); // Reversing chars
        string result = new string(charOfTheNumber); // Put number back into string form
        return result; // returning it to Main method
    }
}