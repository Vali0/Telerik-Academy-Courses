using System;
using System.Collections;

class TribonachiTriangle
{
    static void Main(string[] args)
    {
        Int64[] members = new Int64[3];
        members[0] = Int64.Parse(Console.ReadLine());
        members[1] = Int64.Parse(Console.ReadLine());
        members[2] = Int64.Parse(Console.ReadLine());
        Int64 sum = 0;
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}\n{1} {2}",members[0],members[1],members[2]);
        for (int i = 3; i <= rows ; i++)
        {
            for (int j = 0; j < i; j++)
            {
                sum = members[0] + members[1] + members[2];
                members[0] = members[1];
                members[1] = members[2];
                members[2] = sum;
                Console.Write(sum+" ");
            }
            Console.WriteLine();
        }

    }
}
