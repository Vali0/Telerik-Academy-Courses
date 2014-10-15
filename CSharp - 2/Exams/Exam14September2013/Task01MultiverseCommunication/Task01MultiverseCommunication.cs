using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

class Task01MultiverseCommunication
{
    static void Main(string[] args)
    {
        string[] numbers = MessageEncrypt();

        string input = Console.ReadLine();

        if (input.Length < 4)
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
            for (int j = 0; j < numbers.Length; j++)
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

    private static string[] MessageEncrypt()
    {
        string[] numbers = new string[13];

        numbers[0] = "CHU";
        numbers[1] = "TEL";
        numbers[2] = "OFT";
        numbers[3] = "IVA";
        numbers[4] = "EMY";
        numbers[5] = "VNB";
        numbers[6] = "POQ";
        numbers[7] = "ERI";
        numbers[8] = "CAD";
        numbers[9] = "K-A";
        numbers[10] = "IIA";
        numbers[11] = "YLO";
        numbers[12] = "PLA";
        
        return numbers;
    }

    public static BigInteger MyPow(int pow)
    {
        BigInteger result = 1;
        for (int i = 0; i < pow; i++)
        {
            result *= 13;
        }
        return result;
    }
}