using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] cats = new int[10];
        int judge = 0;
        judge = int.Parse(Console.ReadLine());
        int input;
        for (int i = 0; i < judge; i++)
        {
            input = int.Parse(Console.ReadLine());
            cats[input-1] = cats[input-1] + 1;
        }
        int max = cats.Max();
        int index = 0;
        for (int i = 0; i < cats.Length; i++)
            if (cats[i] == max)
            {
                index = i;
                break;
            }
        Console.WriteLine(index+1);
    }
}