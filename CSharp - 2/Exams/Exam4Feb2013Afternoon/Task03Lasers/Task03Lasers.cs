using System;
using System.Linq;

class Task03Lasers
{
    static void Main(string[] args)
    {
        int[] dims = ReadInput();
        int[] pos = ReadInput();
        int[] vect = ReadInput();

        bool[,,] visited = new bool[dims[0] + 1, dims[1] + 1, dims[2] + 1];
        

        while (true)
        {
            visited[pos[0], pos[1], pos[2]] = true;
            int[] newPos = new int[3];

            for (int i = 0; i < 3; i++)
            {
                newPos[i] = pos[i] + vect[i];
            }

            if (visited[newPos[0], newPos[1], newPos[2]] == true || Bounceses(newPos, dims) == 2)
            {
                Console.WriteLine("{0} {1} {2}", pos[0], pos[1], pos[2]);
                return;
            }

            if (Bounceses(newPos, dims) == 1)
            {
                ReverseVector(newPos, vect, dims);
            }
            for (int i = 0; i < 3; i++)
            {
                pos[i] = newPos[i];
            }
        }
    }

    public static void ReverseVector(int[] newPos, int[] vect, int[] dims)
    {
        for (int i = 0; i < 3; i++)
        {
            if (newPos[i] == 1 && vect[i] == -1)
            {
                vect[i] *= -1;
            }
            else if (newPos[i] == dims[i] && vect[i] == 1)
            {
                vect[i] *= -1;
            }
        }
    }

    public static int Bounceses(int[] newPos, int[] dims)
    {
        int counter = 0;

        for (int i = 0; i < 3; i++)
        {
            if (newPos[i] == 1 || newPos[i] == dims[i])
                counter++;
        }
        return counter;
    }

    public static int[] ReadInput()
    {
        string reader = Console.ReadLine();
        string[] toArray = reader.Split(' ');

        return toArray.Select(s => int.Parse(s)).ToArray();
    }
}