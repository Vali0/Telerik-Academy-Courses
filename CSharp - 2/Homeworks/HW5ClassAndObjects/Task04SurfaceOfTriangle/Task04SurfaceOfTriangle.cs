using System;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

class Task04SurfaceOfTriangle
{
    static void Main(string[] args)
    {
        // Defining all atributes
        double firstSide, secondSide, thirdSide, altitude, angle;

        AreaMethods areaMethods = new AreaMethods();

        Console.WriteLine("Calculating by side and altitude.");
        Console.WriteLine("Enter your first side: ");
        firstSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter your altitude: ");
        altitude = double.Parse(Console.ReadLine());

        Console.WriteLine("The area of a triangle calculated by side and altitude is: " + areaMethods.SideAndAltitude(firstSide, altitude));

        Console.WriteLine("\nCalculating by two sides and angle between them.");
        Console.WriteLine("Enter your first side: ");
        firstSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter your second side: ");
        secondSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter your angle: ");
        angle = double.Parse(Console.ReadLine());

        Console.WriteLine("The area of a triangle calculated by two sides and angle between them is: " + areaMethods.TwoSidesAngle(firstSide, secondSide, angle));

        Console.WriteLine("\nCalculating by three sides.");
        Console.WriteLine("Enter your first side: ");
        firstSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter your second side: ");
        secondSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter your third side: ");
        thirdSide = double.Parse(Console.ReadLine());

        Console.WriteLine("The area of a triangle calculated by three sides is: " + areaMethods.ThreeSides(firstSide, secondSide, thirdSide));
    }
}