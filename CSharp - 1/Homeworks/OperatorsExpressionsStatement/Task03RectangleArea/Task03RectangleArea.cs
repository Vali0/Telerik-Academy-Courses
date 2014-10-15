using System;

class Task03RectangleArea
{
    static void Main(string[] args)
    {
        double width = 0;
        double height = 0;

        try
        {
            Console.WriteLine("Enter width: ");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine("Area of the rectangle is: " + width * height); // Calculating and printing the area
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You entered a letter!");
        }
    }
}
