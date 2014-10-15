using System;

class Task11PrintingCardsName
{
    static void Main(string[] args)
    {
        for (byte card = 1; card <= 13; card++) // Loop for card type
            for (byte color = 1; color <= 4; color++) // Nested loop for color
            {
                switch (card)
                {
                    case 1: Console.Write("Ace"); break;
                    case 2: Console.Write("Two"); break;
                    case 3: Console.Write("Three"); break;
                    case 4: Console.Write("Four"); break;
                    case 5: Console.Write("Five"); break;
                    case 6: Console.Write("Six"); break;
                    case 7: Console.Write("Seven"); break;
                    case 8: Console.Write("Eight"); break;
                    case 9: Console.Write("Nine"); break;
                    case 10: Console.Write("Ten"); break;
                    case 11: Console.Write("Jack"); break;
                    case 12: Console.Write("Queen"); break;
                    case 13: Console.Write("King"); break;
                    default: Console.Write("There is no such a card!"); break; // Just for checking the loop limit
                }
                switch (color)
                {
                    case 1: Console.WriteLine(" of Clubs"); break;
                    case 2: Console.WriteLine(" of Diamonds"); break;
                    case 3: Console.WriteLine(" of Hearts"); break;
                    case 4: Console.WriteLine(" of Spades"); break;
                    default: Console.WriteLine("There is no such a color!"); break; // Just for checking the loop limit
                }
            }
    }
}