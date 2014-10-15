using System;

class Program
{
    static void Main(string[] args)
    {
        int sX1, sX2, sY1, sY2;
        int cX1, cX2, cX3, cY1, cY2, cY3;
        int H;
        sX1 = int.Parse(Console.ReadLine());
        sY1 = int.Parse(Console.ReadLine());
        sX2 = int.Parse(Console.ReadLine());
        H = int.Parse(Console.ReadLine());
        cX1 = int.Parse(Console.ReadLine());
        cY1 = int.Parse(Console.ReadLine());
        cX2 = int.Parse(Console.ReadLine());
        cY2 = int.Parse(Console.ReadLine());
        cX3 = int.Parse(Console.ReadLine());
        cY3 = int.Parse(Console.ReadLine());

        int mark;
        int rad1 = 0;
        int rad2 = 0;
        int rad3 = 0;
        rad1 = Math.Abs(cX1 + H);
        rad2 = Math.Abs(cX2 + H);
        rad3 = Math.Abs(cX3 + H);
        if (rad1 < sX1 && Math.Abs(cY1) < sY1)
        {

        }
    }
}
