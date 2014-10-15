using System;
using System.Collections.Generic;
using System.Text;

class Task02MagicWords
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();
        int maxLength = 0;
        for (int i = 0; i < input; i++)
        {
            string word = Console.ReadLine();
            int temp = word.Length;
            if (maxLength < temp)
            {
                maxLength = temp;
            }
            if( word != null || word != "" || word!= " " || word.Length<0)
            {
                words.Add(word);
            }
        }
        Reorder(words, input);
        Print(words, input, maxLength);
        //foreach (var item in words)
        //{
        //    Console.WriteLine(item);
        //}
    }

    private static void Reorder(List<string> words, int input)
    {
        int index = 0;
        string temp = null;
        for (int i = 0; i < words.Count; i++)
        {
            index = words[i].Length % (input + 1);
            if (index != 0)
            {
                index--;
            }
            temp = words[i];
            words.RemoveAt(i);
            words.Insert(index, temp);
        }
    }

    private static void Print(List<string> list, int input, long max)
    {
        int index = 0;
        StringBuilder sb = new StringBuilder();
        while (index <= max)
        {
            for (int i = 0; i < input; i++)
            {
                if (index < list[i].Length)
                {
                    if (list[i][index] != ' ' )
                    {
                        sb.Append(list[i][index]);
                    }
                }
            }
            index++;
        }

        Console.WriteLine(sb.ToString());
    }
}