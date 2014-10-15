using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int bitLength = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int number = 0;
        int mask, numberAndMask, bit;
        List<int> list = new List<int>();
        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());
            for (int j = Convert.ToString(number, 2).Length - 1; j >= 0; j--)
            {
                mask = 1 << j;
                numberAndMask = number & mask;
                bit = numberAndMask >> j;
                list.Add(bit);
            }
        }
        int zeroCounter = 0;
        int oneCounter = 0;
        int sumCounter = 0;
        int p = 0;
        while (p < list.Count)
        {
            if (list[p] == 0)
            {
                int k = p;
                zeroCounter = 0;
                while (k < list.Count && list[k] == 0)
                {
                    zeroCounter++;
                    k++;
                    if (k == list.Count)
                    {
                        if (zeroCounter == bitLength)
                        {
                            sumCounter++;
                            break;
                        }
                    }
                    else if (zeroCounter == bitLength && list[k] == 1)
                    {
                        sumCounter++;
                        break;
                    }
                }
                p = k;
            }
            if (p!= list.Count && list[p] == 1)
            {
                int k = p;
                oneCounter = 0;
                while (k < list.Count && list[k] == 1)
                {
                    oneCounter++;
                    k++;
                    if (k == list.Count)
                    {
                        if (oneCounter == bitLength)
                        {
                            sumCounter++;
                            break;
                        }
                    }
                    else if (oneCounter == bitLength && list[k] == 0)
                    {
                        sumCounter++;
                        break;
                    }
                }
                p = k;
            }
        }
        Console.WriteLine(sumCounter);

    }
}