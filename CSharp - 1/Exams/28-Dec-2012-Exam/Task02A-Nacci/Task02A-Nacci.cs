using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 0;
        char first, second, third;
        first = char.Parse(Console.ReadLine());
        second = char.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        if (n != 1)
        {
            Console.WriteLine(first);
            Console.Write(second);
            if (Math.Abs(first - 64 + second - 64) <= 26)
            {
                third = (char)(first - 64 + second - 64 + 64);
            }
            else
            {
                third = (char)(Math.Abs(first - 64 + second - 64 - 26 + 64));
            }
            Console.WriteLine(third);
            first = second;
            second = third;

            for (int i = 2; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if ((first - 64 + second - 64) <= 26)
                    {
                        third = (char)(first - 64 + second - 64 + 64);
                    }
                    else
                    {
                        third = (char)(Math.Abs(first - 64 + second - 64 - 26 + 64));
                    }
                    first = second;
                    second = third;
                    if(j==0)
                    Console.Write(third + new String(' ',i-1));
                    else if (j==1)
                        Console.Write(third);
                }
                Console.WriteLine();
            }
        }
        else
            Console.WriteLine(first);
    }
}