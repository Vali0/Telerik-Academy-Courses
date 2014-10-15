using System;
using System.Linq;

/*
Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method. Write a program that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.
*/
class FiguresDemo
{
    static void Main(string[] args)
    {
        // Create few shapes
        Shape[] shapes =
        {
            new Circle(2),
            new Rectangle(1,2),
            new Triangle(5.5,2.999),
            new Circle(123.987),
            new Rectangle(12.3,54.2),
            new Rectangle(0,0),
            new Triangle(0,0),
            new Triangle(99.123,123.99),
            new Circle(0),
        };

        // Print them
        foreach (var item in shapes)
        {
            Console.WriteLine("Figure {0} with area: {1}", item.GetType(), item.CalculateSurface());
        }
    }
}