using System;

namespace CohesionAndCoupling
{
    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                GeometryFigure.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                GeometryFigure.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            GeometryFigure.Width = 3;
            GeometryFigure.Height = 4;
            GeometryFigure.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", GeometryFigure.CalculateVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", GeometryFigure.CalculateDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", GeometryFigure.CalculateDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", GeometryFigure.CalculateDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", GeometryFigure.CalculateDiagonalYZ());
        }
    }
}