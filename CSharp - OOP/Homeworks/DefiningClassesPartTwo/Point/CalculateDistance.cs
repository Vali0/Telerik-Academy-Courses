using System;

static class CalculateDistance
{
    public static double Distance(Point3D first, Point3D second)
    {
        double result = 0;
        result = Math.Sqrt(Math.Pow(first.PointX - second.PointX, 2) + Math.Pow(first.PointY - second.PointY, 2) + Math.Pow(first.PointZ - second.PointY, 2)); // Simple formula
        return result;
    }
}