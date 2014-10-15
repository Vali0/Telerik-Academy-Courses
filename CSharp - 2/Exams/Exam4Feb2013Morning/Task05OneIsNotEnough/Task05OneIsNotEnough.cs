using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
 
class Task05OneIsNotEnough
{
    static void Main(string[] args)
    {
        uint lamps = uint.Parse(Console.ReadLine());
 
        List<string> list = new List<string>();
        for (uint i = 0; i < lamps; i++)
        {
            list.Add((i + 1).ToString());
        }

        int step = 0;
        int starCounter = 0;

        while (starCounter < list.Count-1)
        {
            step++;
            for (int i = step-1; i < list.Count; i = i + 1 + step)
            {
                if (list[i] != "*")
                {
                    list[i] = "*";
                    starCounter++;
                }
            }
        }
        
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 2; i++)
        {
            string commands = Console.ReadLine();
            int R = 0;
            int L = 0;
            R = Regex.Matches(commands, "R").Count;
            L = Regex.Matches(commands, "L").Count;
            if (R != L)
            {
                sb.Append("bounded");
            }
            else
            {
                sb.Append("unbounded");
            }
            if (i == 0)
                sb.AppendLine();
        }
        foreach (var item in list)
        {
            if (item != "*")
            {
                Console.WriteLine(item);
                break;
            }
        }
        Console.WriteLine(sb.ToString());
    }
}