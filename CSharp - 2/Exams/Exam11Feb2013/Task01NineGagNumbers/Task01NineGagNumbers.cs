using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

class Task01NineGagNumbers
{
    static void Main(string[] args)
    {
        string[] numbers = NineGagNumbers();
        string input = Console.ReadLine();
        if (input.Length < 7)
        {
            for (int i = 0; i < 9; i++)
            {
                if (numbers[i] == input)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
        StringBuilder sb = new StringBuilder();
        List<BigInteger> list = new List<BigInteger>();

        for (int i = 0; i < input.Length; i++)
        {
            sb.Append(input[i]);
            for (int j = 0; j < 9; j++)
            {
                if (sb.ToString() == numbers[j])
                {
                    list.Add(j);
                    sb.Clear();
                }
            }
        }
        BigInteger result = 0;

        for (int i = 0; i < list.Count; i++)
        {
            result = list[i] * MyPow(list.Count - i - 1) + result;
        }
        Console.WriteLine(result);
    }

    public static string[] NineGagNumbers()
    {
        string[] numbers = new string[9];
        numbers[0] = "-!";
        numbers[1] = "**";
        numbers[2] = "!!!";
        numbers[3] = "&&";
        numbers[4] = "&-";
        numbers[5] = "!-";
        numbers[6] = "*!!!";
        numbers[7] = "&*!";
        numbers[8] = "!!**!-";

        return numbers;
    }
    public static BigInteger MyPow(int pow)
    {
        BigInteger result = 1;
        for (int i = 0; i < pow; i++)
        {
            result *= 9;
        }
        return result;
    }
}