using System;
using System.Collections.Generic;
using System.Text;

class Task01DurankulakNumbers
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] numbers = DurankulakDigits();

        if (input.Length < 3)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == input)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }

        List<string> list = new List<string>();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            sb.Append(input[i]);
            if (char.IsUpper(input[i]))
            {
                list.Add(sb.ToString());
                sb.Clear();
            }
        }

        List<ulong> values = new List<ulong>();
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] == list[i])
                {
                    values.Add((ulong)j);
                    break;
                }
            }
        }

        ulong result = 0;
        
        for (int i = 0; i < values.Count; i++)
        {
            result = values[i] * (ulong)(Math.Pow(168, values.Count - i - 1)) + result;
        }
        Console.WriteLine(result);
    }
    
    public static string[] DurankulakDigits()
    {
        string[] numbers = new string[168];

        for (int i = 0; i < 168; i++)
        {
            if (i < 26)
            {
                numbers[i] = ((char)('A' + i)).ToString();
            }
            else if (i < 2 * 26)
            {
                numbers[i] = "a" + numbers[i - 26];
            }
            else if (i < 3 * 26)
            {
                numbers[i] = "b" + numbers[i - 2 * 26];
            }
            else if (i < 4 * 26)
            {
                numbers[i] = "c" + numbers[i - 3 * 26];
            }
            else if (i < 5 * 26)
            {
                numbers[i] = "d" + numbers[i - 4 * 26];
            }
            else if (i < 6 * 26)
            {
                numbers[i] = "e" + numbers[i - 5 * 26];
            }
            else if (i < 7 * 26)
            {
                numbers[i] = "f" + numbers[i - 6 * 26];
            }
        }

        return numbers;
    }
}