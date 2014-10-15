using System;
using System.Collections.Generic;
using System.Linq;

class Task043DStars
{
    public static int width, height, depth;
    public static char[,,] cube;
    public static Dictionary<char, int> dictionary = new Dictionary<char, int>();
    public static int starsCounter = 0;

    static void Main(string[] args)
    {
        ReadInput();
        DefineCube();
        CountStars();
        SortStars();

    }

    private static void SortStars()
    {
        var sorted = dictionary.OrderBy(x => x.Key);

        Console.WriteLine(starsCounter);
        foreach (var item in sorted)
        {
            Console.WriteLine("{0} {1}",item.Key,item.Value);
        }
    }

    private static void CountStars()
    {
        for (int w = 1; w < width - 1; w++)
        {
            for (int h = 1; h < height - 1; h++)
            {
                for (int d = 1; d < depth - 1; d++)
                {
                    FindSingleStar(w, h, d);
                }
            }
        }
    }

    private static void FindSingleStar(int currentWidth, int currentHeight, int currDepth)
    {
        char symbol = cube[currentWidth, currentHeight, currDepth];

        bool sameSymbol = cube[currentWidth + 1, currentHeight, currDepth] == symbol &&
                          cube[currentWidth - 1, currentHeight, currDepth] == symbol &&
                          cube[currentWidth, currentHeight + 1, currDepth] == symbol &&
                          cube[currentWidth, currentHeight - 1, currDepth] == symbol &&
                          cube[currentWidth, currentHeight, currDepth + 1] == symbol &&
                          cube[currentWidth, currentHeight, currDepth - 1] == symbol;

        if (sameSymbol)
        {
            starsCounter++;

            if (dictionary.ContainsKey(symbol))
            {
                dictionary[symbol]++;
            }
            else
            {
                dictionary.Add(symbol, 1);
            }
        }
    }

    private static void DefineCube()
    {
        cube = new char[width, height, depth];

        for (int h = 0; h < height; h++)
        {
            string[] line = Console.ReadLine().Split();

            for (int d = 0; d < depth; d++)
            {
                string cubeContent = line[d];
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = cubeContent[w];
                }
            }
        }
    }

    private static void ReadInput()
    {
        string[] input = Console.ReadLine().Split();
        width = int.Parse(input[0]);
        height = int.Parse(input[1]);
        depth = int.Parse(input[2]);
    }
}