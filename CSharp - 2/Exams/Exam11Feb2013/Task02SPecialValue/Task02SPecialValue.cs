using System;

class Task02SPecialValue
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int[][] jigSaw = new int[size][];
        FillJigSaw(jigSaw);
        bool[][] visited = new bool[size][];
        FillVisited(jigSaw, visited);

        long specialValue = 0;
        long temp = 0;
        for (int i = 0; i < jigSaw[0].Length; i++)
        {
            temp = FindSpecialValue(jigSaw, visited, i);
 
            if (specialValue < temp)
            {
                specialValue = temp;
            }
            FillVisited(jigSaw, visited);
        }
        Console.WriteLine(specialValue);
    }

    private static long FindSpecialValue(int[][] jigSaw, bool[][] visited, int column)
    {
        long temp = 0;
        int row = 0;

        while (true)
        {
            temp++;
            if (visited[row][column] == true)
            {
                return -1;
            }
            if (jigSaw[row][column] < 0)
            {
                return (temp -= jigSaw[row][column]);
            }
            visited[row][column] = true;
            
            column = jigSaw[row][column];
            row++;
            if (row == jigSaw.GetLength(0))
            {
                row = 0;
            }
        }
    }

    private static void FillVisited(int[][] jigSaw, bool[][] visited)
    {
        for (int i = 0; i < jigSaw.GetLength(0); i++)
        {
            visited[i] = new bool[jigSaw[i].Length];
        }
    }

    private static void FillJigSaw(int[][] jigSaw)
    {
        for (int i = 0; i < jigSaw.GetLength(0); i++)
        {
            string input = Console.ReadLine();
            string[] splitted = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            jigSaw[i] = new int[splitted.Length];
            for (int j = 0; j < splitted.Length; j++)
            {
                jigSaw[i][j] = int.Parse(splitted[j]);
            }
        }
    }
}