// Refactor the following code to use proper variable naming and simplified expressions:

namespace Task01FigureRefactoring
{
    using System;

    class Figure
    {
        private double width, height;

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid input!. Height should be positive number.");
                }
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
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid input!. Width should be positive number.");
                }
                this.height = value;
            }
        }

        public static Figure RotateFigure(Figure oldFigure, double rotationAngle)
        {
            double rotatedWith = Math.Abs(Math.Cos(rotationAngle)) * oldFigure.Width +
                                 Math.Abs(Math.Sin(rotationAngle)) * oldFigure.Height;
            double rotatedHeight = Math.Abs(Math.Sin(rotationAngle)) * oldFigure.Width +
                                   Math.Abs(Math.Cos(rotationAngle)) * oldFigure.Height;

            Figure rotatedFigure = new Figure(rotatedWith, rotatedHeight);

            return rotatedFigure;
        }
    }
}