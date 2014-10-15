using System;

abstract class Shape
{
    // Fields
    private double width, height;

    // Constructors
    public Shape(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    // Properties
    public double Width
    {
        get
        {
            return this.width;
        }
        set
        {
            this.width = value;
        }
    }

    public double Height
    {
        get
        {
            return this.height;
        }
        set
        {
            this.height = value;
        }
    }

    // Abstract method for calculation of surface of each figure. Could be done with interfece which each figure inherit.
    public abstract decimal CalculateSurface();
}