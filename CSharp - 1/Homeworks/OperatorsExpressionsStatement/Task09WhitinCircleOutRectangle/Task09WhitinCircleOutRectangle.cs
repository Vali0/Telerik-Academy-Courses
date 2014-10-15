using System;

class Task09WhitinCircleOutRectangle
{
    static void Main(string[] args)
    {
        int circleX, circleY, circleRadius;
        int rectangleTop, rectangleLeft, rectangleWidth, rectangleHeight;
        double pointX, pointY;

        circleX = 1;
        circleY = 1;
        circleRadius = 3;
        rectangleTop = 1;
        rectangleLeft = -1;
        rectangleWidth = 6;
        rectangleHeight = 2;

        Console.WriteLine("Enter x coordinate of the point: ");
        pointX = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y coordinate of the point: ");
        pointY = double.Parse(Console.ReadLine());

        if (Math.Pow((pointX - circleX), 2) + Math.Pow((pointY - circleY), 2) <= Math.Pow(circleRadius, 2)) // If point radius vector is <= circle radius
        {
            Console.WriteLine("The point is within the circle!");
            if (pointX < rectangleLeft || pointX > rectangleWidth - 1)
            {
                Console.WriteLine("The point is out of the rectangle!");
            }
            else if (pointY > rectangleTop || pointY < rectangleTop - rectangleHeight)
            {
                Console.WriteLine("The point is out of the rectangle!");
            }
            else
            {
                Console.WriteLine("The point is in the rectangle!");
            }
        }
        else
        {
            Console.WriteLine("Point is not within the circle!");
            if (pointX < rectangleLeft || pointX > rectangleWidth - 1)
            {
                Console.WriteLine("The point is out of the rectangle!");
            }
            else if (pointY > rectangleTop || pointY < rectangleTop - rectangleHeight)
            {
                Console.WriteLine("The point is out of the rectangle!");
            }
            else
            {
                Console.WriteLine("The point is in the rectangle!");
            }
        }

    }
}

