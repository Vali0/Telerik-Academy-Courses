using System;

class Program
{
    static void Main(string[] args)
    {
        int mask, playerAndMask;
        byte player;
        byte bit;
        byte topCounter = 0;
        byte botCounter = 0;
        byte[,] gameField = new byte[8, 8];
        for (int i = 0; i < 8; i++)
        {
            player = byte.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                mask = 1 << j;
                playerAndMask = player & mask;
                bit = (playerAndMask >> j);
                gameField[i, 7 - j] = bit;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            player = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                mask = 1 << j;
                playerAndMask = player & mask;
                bit = (byte)(playerAndMask >> j);
                if (bit == 1 && gameField[i, 7 - j] == 1)
                {
                    gameField[i, 7 - j] = 0;
                }
                else if (gameField[i, 7 - j] == 0 && bit == 1)
                {
                    gameField[i, 7 - j] = 2;
                }
                else if (gameField[i, 7 - j] == 0 && bit == 0)
                    gameField[i, 7 - j] = bit;
            }
        }

        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
            {
                try
                {
                    if (gameField[i, j] == 1 && gameField[i + 1, j] == 0)
                    {
                        gameField[i, j] = 0;
                        gameField[i + 1, j] = 1;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    topCounter++;
                }
                try
                {
                    if (gameField[7 - i, j] == 2 && gameField[7 - i - 1, j] == 0)
                    {
                        gameField[7 - i, j] = 0;
                        gameField[7 - i - 1, j] = 2;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    botCounter++;
                }
            }
        Console.WriteLine("{0}:{1}", topCounter, botCounter);
    }
}
