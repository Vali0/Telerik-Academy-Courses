using System;

class Triangle : Shape
{
    // Constructors
    public Triangle(double width, double height) : base(width, height)
    {
    }

    // Methods
    public override decimal CalculateSurface()
    {
        return (decimal)(Height * Width / 2);
    }
}