using System;

class Task08TrapezoidArea
{
    static void Main(string[] args)
    {
        double sideA, sideB, heightH, area;

        Console.WriteLine("Enter side a: ");
        sideA = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter side b: ");
        sideB = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter height: ");
        heightH = double.Parse(Console.ReadLine());

        area = (sideA + sideB) * heightH / 2; // Calculating trapezoid area
        Console.WriteLine("Area of trapezoid is: " + area); // Printing it
    }
}

