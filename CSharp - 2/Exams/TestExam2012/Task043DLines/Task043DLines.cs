using System;

class Task043DLines
{
    private static int width, height, dept;
    
    private static char[,,] cube;
    private static int[] dirWidth = { 1, 0, 1, -1, 0, 0, 0, 1, -1, 1, 1, 1, 1 };
    private static int[] dirHeight = { 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, -1, 1, -1 };
    private static int[] dirDepth = { 0, 0, 1, 1, 1, 1, -1, 0, 0, 1, 1, -1, -1 };
    private static int bestLength = 1;
    private static int numberOfLines = 0;

    static void Main(string[] args)
    {
        ReadInput();
        FillCube();

        for (int w = 0; w < width; w++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int d = 0; d < dept; d++)
                {
                    FindMax(w, h, d);
                }
            }
        }
        if (numberOfLines != 0)
        {
            Console.WriteLine("{0} {1}", bestLength, numberOfLines);
        }
        else
        {
            Console.WriteLine(-1);
        }
    }

    private static void FindMax(int w, int h, int d)
    {
        char symbol = cube[w, h, d];
        for (int i = 0; i < dirDepth.Length; i++)
        {
            int curWidth = w;
            int curHeight = h;
            int curDept = d;
            int curLength = 1;

            while (true)
            {
                curWidth += dirWidth[i];
                curHeight += dirHeight[i];
                curDept += dirDepth[i];
                if (!IsInCube(curWidth, curHeight, curDept))
                {
                    break;
                }
                if (symbol == cube[curWidth, curHeight, curDept])
                {
                    curLength++;
                }
                else
                {
                    break;
                }

                if (curLength > bestLength)
                {
                    bestLength = curLength;
                    numberOfLines = 1;
                }
                else if (curLength == bestLength)
                {
                    numberOfLines++;
                }
            }
        }
    }

    private static bool IsInCube(int curWidth, int curHeight, int curDept)
    {
        if (curWidth >= 0 && curWidth < width && curHeight >= 0 && curHeight < height && curDept >= 0 && curDept < dept)
        {
            return true;
        }
        return false;
    }

    private static void ReadInput()
    {
        string[] dims = Console.ReadLine().Split();
        width = int.Parse(dims[0]);
        height = int.Parse(dims[1]);
        dept = int.Parse(dims[2]);

        cube = new char[width, height, dept];
    }

    private static void FillCube()
    {
        for (int h = 0; h < height; h++)
        {
            string[] input = Console.ReadLine().Split();
            for (int d = 0; d < dept; d++)
            {
                string cubeContent = input[d];
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = cubeContent[w];
                }
            }
        }
    }
}