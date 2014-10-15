using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new String('.',i));
            Console.Write(new String('*',n-2*i));
            Console.WriteLine(new String('.',i));
        }
        for (int i = n / 2; i >= 0; i--)
        {

            Console.Write(new String('.', i));
            Console.Write(new String('*', n - 2 * i));
            Console.WriteLine(new String('.', i));
        }
    }
}