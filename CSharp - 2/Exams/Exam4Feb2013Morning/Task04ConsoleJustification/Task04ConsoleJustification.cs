using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

class Task04ConsoleJustification
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        StringBuilder text = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            text.AppendLine(input);
        }
        
        string[] words = text.ToString().Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder sb = new StringBuilder();

        BigInteger currLength = 0;
        List<string> list = new List<string>();

        for (int i = 0; i < words.Length; i++)
        {
            currLength += words[i].Length;
            if (currLength < width)
            {
                sb.Append(words[i]);
                sb.Append(" ");
                currLength++;
            }
            else if (currLength == width)
            {
                sb.Append(words[i]);
                list.Add(sb.ToString().Trim());
                sb.Clear();
                currLength = 0;
            }
            else
            {
                list.Add(sb.ToString().Trim());
                sb.Clear();
                i--;
                currLength = 0;
            }
        }

        if (sb.ToString() != null)
        {
            list.Add(sb.ToString().Trim());
        }

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Length < width && Regex.Matches(list[i], " ").Count > 0)
            {
                int interval = list[i].IndexOf(' ');
                while (list[i].Length < width)
                {
                    while (list[i].Substring(interval, 1) == " ")
                    {
                        interval++;
                    }
                    
                    list[i] = list[i].Insert(interval, " ");
                    
                    interval = list[i].IndexOf(' ', interval + 1); // Maybe plus 2
                    if (interval == -1)
                    {
                        interval = list[i].IndexOf(' ', 0);
                    }
                }
            }
        }
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}