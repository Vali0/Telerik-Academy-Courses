using System;
using System.Collections.Generic;

class Task03Indices
{
    private static List<string> list = new List<string>();

    static void Main(string[] args)
    {
        long size = long.Parse(Console.ReadLine());

        string[] input = Console.ReadLine().Split();
        long[] array = new long[size];

        for (long i = 0; i < size; i++)
        {
            array[i] = long.Parse(input[i]);    
        }
        bool[] visited = new bool[size];
        SearchCycle(array, 0, size, visited);
    }

    private static void SearchCycle(long[] array, long index, long size, bool[] visited)
    {
        if (index < size)
        {
            if (visited[index] == true)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (i != list.Count - 1)
                    {
                        if (i == index)
                        {
                            Console.Write(list[i] + "(");
                        }
                        else
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    else
                    {
                        Console.WriteLine(list[i]+")");
                    }
                }
            }

            else
            {
                list.Add(index.ToString());
                visited[index] = true;
                index = array[index];
                SearchCycle(array, index, size, visited);
            }
        }
        else
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count - 1)
                {
                    Console.Write(list[i]+ " ");
                }
                else
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
    }
}