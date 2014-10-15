using System;

class Rectangle : Shape
{
    // Constructors
    public Rectangle(double width, double height) : base(width, height)
    {
    }
    
    // Methods
    public override decimal CalculateSurface()
    {
        return (decimal)(Height * Width);
    }
}