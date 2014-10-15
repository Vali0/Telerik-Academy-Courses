using System;

class Task06WithinACircle
{
    static void Main(string[] args)
    {
        int circleRadius = 5;
        double pointCoordinateX = 0;
        double pointCoordinateY = 0;
        double pointRadiusVector = 0;

        Console.WriteLine("Enter X coordinate of the point: ");
        pointCoordinateX = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate of the point: ");
        pointCoordinateY = int.Parse(Console.ReadLine());

        pointRadiusVector = Math.Sqrt(Math.Pow(pointCoordinateX,2) + Math.Pow(pointCoordinateY,2)); // Calculating point radius vector

        if (pointRadiusVector > circleRadius) 
            Console.WriteLine("Point is not whitin the circle");
        else
            Console.WriteLine("Point is whitin the circle");
    }
}

