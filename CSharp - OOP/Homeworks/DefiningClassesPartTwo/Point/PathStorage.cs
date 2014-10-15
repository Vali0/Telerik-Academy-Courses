using System;
using System.IO;

static class PathStorage
{
    public static void SavePath(Path path)
    {
        using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/Paths.txt"))
        {
            foreach (var item in path.Points)
            {
                // Saving only coordinates into the file (less memory)
                writer.Write(item.PointX + " ");
                writer.Write(item.PointY + " ");
                writer.WriteLine(item.PointZ);
            }
        }
        path.ClearPaths(); // Clearing the list
    }

    public static Path LoadPath()
    {
        Path loadedPath = new Path(); // Making object of Path class
        using (StreamReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/Paths.txt"))
        {
            Point3D point = new Point3D(); // Making point instance
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] coordinates = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                point.PointX = int.Parse(coordinates[0]);
                point.PointY = int.Parse(coordinates[1]);
                point.PointZ = int.Parse(coordinates[2]);
                loadedPath.AddPoint(point); // Saving the point into the list
                line = reader.ReadLine();
            }
        }
        return loadedPath; // returning the LIST!
    }
}