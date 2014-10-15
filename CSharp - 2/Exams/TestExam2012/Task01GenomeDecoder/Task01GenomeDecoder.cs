using System;
using System.Collections.Generic;
using System.Text;

class Task01GenomeDecoder
{
    private static int coutnerForSymbols;
    private static int symbols;
    private static int rows = 1;

    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int symbolPerLine = int.Parse(input[0]);
        int sequenceOfSymbols = int.Parse(input[1]);

        string genome = Console.ReadLine();

        int num = 0;
        List<int> digits = new List<int>();
        int number = 0;

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < genome.Length; i++)
        {
            if (Int32.TryParse(genome[i].ToString(), out num))
            {
                digits.Add(num);
            }
            else
            {
                if (digits.Count == 0)
                {
                    digits.Add(1);
                }
                number = ConvertListToInt(digits);
                sb.Append(DecodeGenome(number, genome[i], symbolPerLine, sequenceOfSymbols));
                digits.Clear();
            }
        }
        string[] split = sb.ToString().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        int maxLength = split[0].Length + rows.ToString().Length - 1;

        if (split.Length > 9)
        {
            for (int i = 0; i < split.Length-1; i++)
            {
                split[i] = split[i].Insert(0, new string(' ',maxLength-split[i].Length));
            }
        }
        foreach (var item in split)
        {
            Console.WriteLine(item);
        }
    }

    private static string DecodeGenome(int number, char p, int symbolsPerLine, int sequenceOfSymbols)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < number; i++)
        {
            if (symbols == 0)
            {
                sb.Append(rows + " ");
            }

            sb.Append(p);
            coutnerForSymbols++;
            symbols++;

            if (sequenceOfSymbols == coutnerForSymbols)
            {
                if (symbols != symbolsPerLine)
                {
                    sb.Append(" ");
                }
                coutnerForSymbols = 0;
            }
            if (symbolsPerLine == symbols)
            {
                sb.AppendLine();
                rows++;
                symbols = 0;
                coutnerForSymbols = 0;
            }
        }
        return sb.ToString();
    }

    private static int ConvertListToInt(List<int> list)
    {
        StringBuilder result = new StringBuilder();
        foreach (var item in list)
        {
            result.Append(item);
        }
        return int.Parse(result.ToString());
    }
}