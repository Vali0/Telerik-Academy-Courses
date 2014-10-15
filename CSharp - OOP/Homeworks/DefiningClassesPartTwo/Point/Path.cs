using System;
using System.Collections.Generic;

class Path
{
    private List<Point3D> points = new List<Point3D>(); // List of Points

    public List<Point3D> Points
    {
        get
        {
            return this.points;
        }
    }

    // Method for addings points
    public void AddPoint(Point3D point)
    {
        points.Add(point);
    }

    public void ClearPaths()
    {
        points.Clear();
    }
}