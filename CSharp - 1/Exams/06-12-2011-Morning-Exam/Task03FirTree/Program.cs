using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string('.', n - i - 2));
            Console.Write(new string('*', 2*i + 1));
            Console.WriteLine(new string('.', n - i - 2));
        }
        Console.Write(new string('.', n - 2));
        Console.Write('*');
        Console.WriteLine(new string('.', n - 2));
    }
}
