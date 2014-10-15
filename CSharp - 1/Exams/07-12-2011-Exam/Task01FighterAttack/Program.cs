using System;

class Program
{
    static void Main(string[] args)
    {
        int Px1, Px2, Py1, Py2, Fx1, Fy1, D;
        Px1 = int.Parse(Console.ReadLine());
        Py1 = int.Parse(Console.ReadLine());
        Px2 = int.Parse(Console.ReadLine());
        Py2 = int.Parse(Console.ReadLine());
        Fx1 = int.Parse(Console.ReadLine());
        Fy1 = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());
        int dmg = 0;

        if (Px1 > Px2)
        {
            Px1 ^= Px2;
            Px2 ^= Px1;
            Px1 ^= Px2;
        }
        if (Py1 > Py2)
        {

            Py1 ^= Py2;
            Py2 ^= Py1;
            Py1 ^= Py2;
        }

        if ((Fx1 + D <= Px2 && Fx1 + D >= Px1) && (Fy1 >= Py1 && Fy1 <= Py2))
        {
            dmg += 100;
        }
        if ((Fx1 + D + 1 <= Px2 && Fx1 + D + 1 >= Px1) && (Fy1 >= Py1 && Fy1 <= Py2))
        {
            dmg += 75;
        }
        if ((Fx1 + D <= Px2 && Fx1 + D >= Px1) && (Fy1 + 1 >= Py1 && Fy1 + 1 <= Py2))
        {
            dmg += 50;
        }
        if ((Fx1 + D <= Px2 && Fx1 + D >= Px1) && (Fy1 - 1 >= Py1 && Fy1 - 1 <= Py2))
        {
            dmg += 50;
        }

        Console.WriteLine(dmg + "%");
    }
}