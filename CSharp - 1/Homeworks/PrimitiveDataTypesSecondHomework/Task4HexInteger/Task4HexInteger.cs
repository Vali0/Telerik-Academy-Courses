using System;

class Task4HexInteger
    {
        static void Main(string[] args)
        {
            int hexInteger = 0xFE; //Declarating and initializing integer variable with hexadecimal value
            Console.WriteLine("Decimal value is: "+hexInteger); // Printing value in decimal format
            Console.WriteLine("Hexidecimal value is: {0:X}", hexInteger); // Printing value in hexidecimal format
        }
    }
