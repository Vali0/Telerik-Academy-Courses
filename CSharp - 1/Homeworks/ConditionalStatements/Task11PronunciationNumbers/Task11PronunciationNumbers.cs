using System;

class Task11PronunciationNumbers
{
    static void Main()
    {
        int number = 0;
        // do-while statement for correct input by user side
        do
        {
            Console.WriteLine("Enter you number(between 0 and 999) inclusive: ");
            number = int.Parse(Console.ReadLine());
        }
        while (number < 0 || number > 999);

        // Two arrays from string which contains the number pronunciation
        string[] numbersTillNineteen = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tensFromNumber = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        
        // Tricky part starts here
        if (number < 20) // If the number pronunciation contains in the array by it self and don't need anything else
            Console.Write(numbersTillNineteen[number]);
        else if (number > 19 && number < 100) // Between 20 and 99 inclusive
        {
            Console.Write(tensFromNumber[number / 10 - 2]); // Getting first digit and decrease it with two (because our array starts from twenty which is '2')
            if (number % 10 != 0) // If the second digit is diffrent by zero
                Console.Write(" " + numbersTillNineteen[number % 10]); // Getting that digit and printing it's name
        }
        else if (number > 99) // When our number is bigger than 100 inclusive (less than 999 is provided by do-while)
        {
            int realPart = number; // Variable for real part after dividing
            number = number / ((int)(Math.Pow(10, 3 - 1))); // Getting first digit. Need to perform type casting because Math.Pow
            realPart = realPart % ((int)(Math.Pow(10, 3 - 1))); // Getting last two digits, in one number
            Console.Write(numbersTillNineteen[number] + " hundred "); // Printing first digit pronunciation

            if (realPart < 19 && realPart != 0)
                Console.Write("and " + numbersTillNineteen[realPart]); // If the number pronunciation contains in the array by it self and don't need anything else
            else if (realPart > 19 && realPart != 0)
            {
                Console.Write("and " + tensFromNumber[(realPart / 10) - 2]); // Printing second digit pronunciation (decrease by two because array size... I explain why little above)
                Console.Write(" " + numbersTillNineteen[(realPart % 10)]); // And finaly printing the last digit pronunciation
            }
        }
        /* And tricky part ends here
        * I've tried to explain it as good as I can
        * It's not too hard, just a lot of math and work with array's bounds
        */
         Console.WriteLine(); // Just new line for console routine output
    }
}