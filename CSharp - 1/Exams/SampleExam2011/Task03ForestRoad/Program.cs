using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', i));
            Console.Write('*');
            Console.WriteLine(new string('.', n - i - 1));
        }
        for (int i = n-1; i > 0; i--)
        {

            Console.Write(new string('.', i-1));
            Console.Write('*');
            Console.WriteLine(new string('.', n -i));
        }
    }
}