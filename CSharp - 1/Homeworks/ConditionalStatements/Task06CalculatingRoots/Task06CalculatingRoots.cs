using System;

class Task06CalculatingRoots
{
    static void Main(string[] args)
    {
        try
        {
            // Defining and intializing variables through console
            double coefA, coefB, coefC, firstRoot, secondRoot, discriminant;
            Console.WriteLine("Enter coeficient A: ");
            coefA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coeficient B: ");
            coefB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coeficient C: ");
            coefC = double.Parse(Console.ReadLine());

            discriminant = Math.Pow(coefB, 2) - 4 * coefA * coefC; // Calculating the discriminant

            if (discriminant > 0) // If it is positive we have two different roots
            {
                firstRoot = ((-coefB) + Math.Sqrt(discriminant)) / (2 * coefA); // Calculating the first root
                secondRoot = ((-coefB) - Math.Sqrt(discriminant)) / (2 * coefA); // Calculating the second root
                Console.WriteLine("First root is: " + firstRoot + "\nSecond root is: " + secondRoot); // Printing the roots
            }
            else if (discriminant == 0) // If it is zero which means two equal roots
            {
                firstRoot = (-coefB) / (2 * coefA);  // Calculating the root
                Console.WriteLine("First root and second root are equal to: " + firstRoot); // Printing it
            }
            else // If the discriminant is negative which means no real roots
            {
                Console.WriteLine("Quadratic equation has imaginary roots");
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You entered letter or symbol!");
        }
    }
}
