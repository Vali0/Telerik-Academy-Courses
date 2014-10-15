using System;

class Program
{
    static void Main(string[] args)
    {
        int number, mask, numberAndMask, bit;
        int[,] grid = new int[8, 8];
        string direction = "South";
        for (int i = 0; i < 8; i++)
        {
            number = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                mask = 1 << j;
                numberAndMask = number & mask;
                bit = numberAndMask >> j;
                grid[i, 7 - j] = bit;
            }
        }


        //for (int i = 0; i < 8; i++)
        //{
        //    for (int j = 0; j < 8; j++)
        //        Console.Write(grid[i, j]);
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //Console.WriteLine();
        int counter = 0;
        int cycle = -1;
        int row = 0;
        int col = 7;
        while (true)
        {

            if (direction == "South")
            {
                cycle++;
                int i = row;
                int j = col;
                try
                {
                    while (grid[i, j] != 1)
                    {
                        grid[i, j] = 2;
                        i++;
                        counter++;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    if (j != 0)
                    {
                        direction = "West";
                    }
                    else break;
                }
                row = i - 1;
                col = j - 1;
                if (grid[row, col] != 1)
                    direction = "West";
                else break;
            }
            if (direction == "West")
            {
                cycle++;
                int i = row;
                int j = col;
                try
                {
                    while (grid[i, j] != 1)
                    {
                        grid[i, j] = 2;
                        j--;
                        counter++;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    if (j != -1)
                        j++;
                }

                row = i - 1;
                col = j + 1;
                if (grid[row, col] != 1)
                {
                    direction = "Nort";
                }
                else break;
            }
            if (direction == "Nort")
            {
                cycle++;
                int i = row;
                int j = col;
                try
                {
                    while (grid[i, j] != 1)
                    {
                        grid[i, j] = 2;
                        i--;
                        counter++;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    i++;
                }
                row = i;
                col = j - 1;
                if (grid[row, col + 1] != 1)
                    direction = "West";
                else break;
            }

            if (direction == "West")
            {
                cycle++;
                int i = row;
                int j = col;
                try
                {
                    while (grid[i, j] != 1)
                    {
                        grid[i, j] = 2;
                        j--;
                        counter++;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    j++;
                }
                row = i + 1;
                col = j;
                if (grid[row, col] != 1)
                    direction = "South";
                else break;
            }
        }
        //for (int i = 0; i < 8; i++)
        //{
        //    for (int j = 0; j < 8; j++)
        //        Console.Write(grid[i, j]);
        //    Console.WriteLine();
        //}
        if (cycle>3)
        {
            Console.Write(counter);
            Console.WriteLine(" "+cycle);
        }
        else
            Console.WriteLine("No "+counter);
    }
}
