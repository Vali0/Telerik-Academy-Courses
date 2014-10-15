using System;

class Task02CirclePerimeterArea
{
    static void Main(string[] args)
    {
        int radius;
        Console.WriteLine("Enter the radius of the circle: ");
        radius = int.Parse(Console.ReadLine());
        Console.WriteLine("Circle perimeter is : " + 2 * Math.PI * radius); // Calculating perimeter of the circle
        Console.WriteLine("Circle area is : " + Math.PI * Math.Pow(radius, 2)); // Calculating area of the circle
    }
}