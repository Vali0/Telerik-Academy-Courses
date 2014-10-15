using System;

class Task06QuadraticEquationRoots
{
    static void Main(string[] args)
    {
        //Defining values
        double coefA, coefB, coefC, firstRoot, secondRoot, discriminant;
        
        //Reading values from console
        Console.WriteLine("Enter coefficient a: ");
        coefA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient b: ");
        coefB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient c: ");
        coefC = double.Parse(Console.ReadLine());

        discriminant = Math.Pow(coefB, 2) - 4 * coefA * coefC; // Calculating discriminant

        if (discriminant > 0)
        {
            firstRoot = (-coefB - Math.Sqrt(discriminant)) / (2 * coefA);
            secondRoot = (-coefB + Math.Sqrt(discriminant)) / (2 * coefA);
            Console.WriteLine("First root is {0} \nSecond is: {1}",firstRoot,secondRoot); 
        }
        else if (discriminant == 0)
        {
            firstRoot = (-coefB) / (2 * coefA);
            Console.WriteLine("First root and second have same value: " +firstRoot);
        }
        else
        {
            Console.WriteLine("Equation has imaginary roots!");
        }
    }
}
