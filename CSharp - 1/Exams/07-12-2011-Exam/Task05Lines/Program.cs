using System;

class Program
{
    static void Main(string[] args)
    {
        int number, mask, numberAndMask, bit;
        int[,] arr = new int[8, 8];
        for (int i = 0; i < 8; i++)
        {
            number = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                mask = 1 << j;
                numberAndMask = number & mask;
                bit = numberAndMask >> j;
                arr[i, 7 - j] = bit;
            }
        }

        long oldRowCounter = 0;
        long oldColCounter = 0;
        long rowCounter = 0;
        long colCounter = 0;
        long rowMaxCounter = 0;
        long colMaxCounter = 0;

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (arr[i, j] == 1)
                {
                    oldRowCounter = 0;
                    int k = j;
                    while (k<8 && arr[i, k] != 0)
                    {
                        oldRowCounter++;
                        k++;
                    }
                    if (rowCounter == oldRowCounter)
                    {
                        rowMaxCounter++;
                    }
                    else if (rowCounter < oldRowCounter)
                    {
                        rowCounter = oldRowCounter;
                        rowMaxCounter = 1;
                    }
                    j = k;
                }
            }
        }
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (arr[j, i] == 1)
                {
                    oldColCounter = 0;
                    int k = j;
                    while (k<8 && arr[k, i] != 0)
                    {
                        oldColCounter++;
                        k++;
                    }
                    if (colCounter == oldColCounter)
                    {
                        colMaxCounter++;
                    }
                    else if (colCounter < oldColCounter)
                    {
                        colCounter = oldColCounter;
                        colMaxCounter = 1;
                    }
                    j = k;
                }
            }
        }
        if (colCounter == rowCounter)
        {
            Console.WriteLine(colCounter);
            Console.WriteLine(colMaxCounter+rowMaxCounter);
        }
        else if (colCounter < rowCounter)
        {
            Console.WriteLine(rowCounter);
            Console.WriteLine(rowMaxCounter);
        }
        else if(colCounter>rowCounter)
        {
            Console.WriteLine(colCounter);
            Console.WriteLine(colMaxCounter);
        }
    }
}
