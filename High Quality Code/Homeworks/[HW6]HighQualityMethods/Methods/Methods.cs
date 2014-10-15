namespace Methods
{
    using System;

    public static class Methods
    {
        // Calculating triangle area using Herone formula
        private static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should be positive!");
            }

            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(halfPerimeter *
                                    (halfPerimeter - sideA) *
                                    (halfPerimeter - sideB) *
                                    (halfPerimeter - sideC));
            return area;
        }

        // Converting passed digit into its English pronunciation 
        private static string ConvertDigitToWord(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    throw new ArgumentException("Invalid digit!");
            }
        }

        // Finding max element into passed array
        private static int FindMaxNumber(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Array is not initialized!");
            }
            if (elements.Length == 0)
            {
                throw new ArgumentException("Array is empty!");
            }

            int maxNumber = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxNumber)
                {
                    maxNumber = elements[i];
                }
            }
            return maxNumber;
        }

        private static void PrintAsNumber(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        private static void PrintAsPersent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        private static void PrintRightAlignet(object number)
        {
            Console.WriteLine("{0,8}", number);
        }

        // Calculate distance between two points
        private static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            return distance;
        }

        private static bool IsHorizontal(double y1, double y2)
        {
            bool isHorizontal = (y1 == y2);

            return isHorizontal;
        }

        private static bool IsVertical(double x1, double x2)
        {
            bool isVertical = (x1 == x2);

            return isVertical;
        }

        private static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(ConvertDigitToWord(5));

            Console.WriteLine(FindMaxNumber(5, -1, 3, 2, 14, 2, 3));
            
            PrintAsNumber(1.3);
            PrintAsPersent(0.75);
            PrintRightAlignet(2.30);

            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5));
            bool horizontal = IsHorizontal(-1, 2.5);
            Console.WriteLine("Horizontal? " + horizontal);
            bool vertical = IsVertical(3, 3);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", "17.03.1992", "Form Vidin, gamer, high results");
            Student stella = new Student("Stella", "Markova", "03.11.1993", "From Vidin, gamer, high results");

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}