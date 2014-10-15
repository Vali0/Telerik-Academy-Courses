using System;

struct Point3D
{
    // Fields
    private int pointX, pointY, pointZ;
    private static Point3D euclidianCenter = new Point3D(0,0,0);

    // Constructor
    public Point3D(int pointX, int pointY, int pointZ) : this()
    {
        this.PointX = pointX;
        this.PointY = pointY;
        this.PointZ = pointZ;
    }

    public static string EuclidianCenter
    {
        get
        {
            return euclidianCenter.ToString();
        }
    }

    // Properties
    public int PointX
    {
        get
        {
            return this.pointX;
        }
        set
        {
            this.pointX = value;
        }
    }

    public int PointY
    {
        get
        {
            return this.pointY;
        }
        set
        {
            this.pointY = value;
        }
    }

    public int PointZ
    {
        get
        {
            return this.pointZ;
        }
        set
        {
            this.pointZ = value;
        }
    }

    // ToString() overriding
    public override string ToString()
    {
        return String.Format("X coordinate: {0}\nY coordinate: {1}\nZ coordinate: {2}",this.PointX,this.PointY,this.PointZ);
    }
}