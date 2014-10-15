using System;

class Task12SimpleMatrix
{
    static void Main(string[] args)
    {
        byte range, counter;
        try
        {
            // do-while statement for matrix size constrains
            do
            {
                Console.WriteLine("Enter how big will be your quadratic matrix(from 1 to 20): ");
                range = byte.Parse(Console.ReadLine());
            } while (range < 1 || range > 19);

            for (byte i = 1; i <= range; i++)
            {
                counter = i; // Remember the first element at the row
                for (int j = 1; j <= range; j++)
                {
                    if (j != range) // If the element isn't the last
                    {
                        Console.Write(counter + " "); // Printing space after element
                        counter++;
                    }
                    else // If the leement is the last on the row
                    {
                        Console.Write(counter); // Printing it without space
                    }
                }
                Console.WriteLine(); // Just new line after last element could be putted in else
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You entered letter or symbol!");
        }
    }
}