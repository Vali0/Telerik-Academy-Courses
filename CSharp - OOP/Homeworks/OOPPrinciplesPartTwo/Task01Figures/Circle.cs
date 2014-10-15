using System;

class Circle : Shape
{
    // form task: "...constructor so that at initialization height must be kept equal to width...". so I think it must be:
    // : base(radius,radius);
    // But I actualy prefer : base(radius,0); because raius could be big and that mean much memory

    // Constructors
    public Circle(double radius) : base(radius, 0)
    {
    }

    // Properties need for radius
    public double Radius
    {
        get
        {
            return base.Width;
        }
        set
        {
            base.Width = value;
        }
    }

    // Methods
    public override decimal CalculateSurface() // Overriding 
    {
        return (decimal)(Width * Width * Math.PI);
    }
}