using System;

// 1. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
//Implement the ToString() to enable printing a 3D point.
// 2. Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
//Add a static property to return the point O.
// 3. Write a static class with a static method to calculate the distance between two points in the 3D space.
// 4. Create a class Path to hold a sequence of points in the 3D space. 
//Create a static class PathStorage with static methods to save and load paths from a text file. 
//Use a file format of your choice.

class PointsDemo
{
    static void Main(string[] args)
    {
        // Creating two points
        Point3D firstPoint = new Point3D(1, 1, 1);
        Point3D secondPoint = new Point3D(2, 3, 4);

        // Printing them using overrided method ToString()
        Console.WriteLine(firstPoint.ToString());
        Console.WriteLine(secondPoint.ToString());
        Console.WriteLine(Point3D.EuclidianCenter); // Printing static center point0(0,0,0) using property
        Console.WriteLine("The distance is: " + CalculateDistance.Distance(firstPoint, secondPoint)); // Calculating distance between two

        // Creating path
        Path path = new Path();
        // Adding the two points into the list
        path.AddPoint(firstPoint);
        path.AddPoint(secondPoint);
        PathStorage.SavePath(path); // Save that path into text file (at desktop)
        path = null; // Make it null to show that there is no "shmenti kapeli"

        Path loadedPath = new Path(); // Load the path could be done on the same instance:
        // path = PathStorage.LoadPath();
        loadedPath = PathStorage.LoadPath();

        // Printing all loaded paths
        foreach (var item in loadedPath.Points)
        {
            Console.WriteLine(item);
        }
    }
}