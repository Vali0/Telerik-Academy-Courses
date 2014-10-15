using System;

class Program
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        double theShit = (n*n + 1/(m*p) +1337)/(n- 128.523123123*p) + Math.Sin((int)m%180);
        Console.WriteLine("{0:F6}",theShit);
    }
}