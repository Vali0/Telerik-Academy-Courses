using System;

class Task03ExelColumns
{
    static void Main(string[] args)
    {
        int n;
        ulong output = 0u;
        n = int.Parse(Console.ReadLine());
        char[] sheet = new char[n];
        for (int i = 0; i < n; i++)
            sheet[i] = char.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                output += (ulong)(sheet[i] - 64) * (ulong)Math.Pow(26, n - i - 1);
            }
        Console.WriteLine(output);
    }
}