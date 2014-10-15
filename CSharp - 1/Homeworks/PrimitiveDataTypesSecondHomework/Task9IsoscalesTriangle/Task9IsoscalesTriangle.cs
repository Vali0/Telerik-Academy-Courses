using System;
using System.Text;

class Task9IsoscalesTriangle
{
    static void Main(string[] args)
    {
        // Declarating variables
        int intervalsCounter = 0;
        int starsCounter = 0;
        char symbol = '\u00A9';
        Console.OutputEncoding = Encoding.Unicode; // To represent special symbol
        //Loop starts here
        for (int i = 0; i < 4; i++)
        {
            // Initializing variables
            intervalsCounter = 4 - i;
            starsCounter = 2 * i - 1;
            while (intervalsCounter > 0) //Loop for printing the intervalsCounter
            {
                Console.Write(" ");
                intervalsCounter--;
            }
            while (starsCounter > 0) // Loop for printing symbols
            {
                Console.Write(symbol);
                starsCounter--;
            }
            Console.Write("\n"); // Just new line
        }
        //Loop ends here
    }
}
