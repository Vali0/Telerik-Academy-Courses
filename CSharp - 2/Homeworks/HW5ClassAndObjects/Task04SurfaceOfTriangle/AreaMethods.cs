using System;

class AreaMethods
{
    public double SideAndAltitude(double side, double altitude)
    {
        double result = (side * altitude) / 2;
        return result;
    }

    public double ThreeSides(double firstSide, double secondSide, double thirdSide)
    {
        double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
        double result = Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide) * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));
        if (result == 0)
        {
            throw new ArithmeticException("Wrong sides!");
        }
        return result;
    }

    public double TwoSidesAngle(double firstSide, double secondSide, double angle)
    {
        double result = (firstSide * secondSide * Math.Sin((Math.PI * angle) / 180)) / 2;
        return result;
    }
}