using System;

/* Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
x2 + 5 = 1x2 + 0x + -> 5,0,1 Extend the program to support also subtraction and multiplication of polynomials. */

class Task11And12Polynomials
{
    static void Main(string[] args)
    {
        // Program could run with more coefficients just kept the rule - enter zeroes!!! Only implement arrays size.

        Console.WriteLine("Enter your first polynomial coefficients(x^2 + 5 = 1*x^2 + 0*x + 5 -> 5,0,1)");
        int[] firstPoly = new int[3];

        Console.WriteLine("Initialize first polynomial");
        for (int i = 0; i < firstPoly.Length; i++)
        {
            firstPoly[i] = int.Parse(Console.ReadLine());
        }

        int[] secondPoly = new int[3];

        Console.WriteLine("Enter your second polynomial coefficients(x^2 + 5 = 1*x^2 + 0*x + 5 -> 5,0,1)");
        Console.WriteLine("Initialize second polynomial");
        for (int i = 0; i < secondPoly.Length; i++)
        {
            secondPoly[i] = int.Parse(Console.ReadLine());
        }

        int[] sumOfThePoly = AddPoly(firstPoly, secondPoly); // Sum polynomials
        Console.Write("\nThe sum of the polynomials is: ");
        PrintPoly(sumOfThePoly); // Print polynomials sum

        int[] substractPoly = SubstractPoly(firstPoly, secondPoly); // Substract polynomials
        Console.Write("\nThe subtract of hte polynomials is: ");
        PrintPoly(substractPoly); // Print polynomials substract

        int[] multiplyPoly = MultiplyPoly(firstPoly, secondPoly); // Multiply polynomials
        Console.Write("\nThe multiplication of the polynomials is: ");
        PrintPoly(multiplyPoly);
        Console.WriteLine(); // Just new line for command prompt
    }

    static int[] AddPoly(int[] firstPoly, int[] secondPoly)
    {
        int[] result = new int[firstPoly.Length];

        // Simple loop with simple summing in it. Size doesn't matter they are equal!
        for (int i = 0; i < firstPoly.Length; i++)
        {
            result[i] = firstPoly[i] + secondPoly[i];
        }
        return result;
    }

    // Simple loop with simple substract in it. Size doesn't matter they are equal!
    static int[] SubstractPoly(int[] firstPoly, int[] secondPoly)
    {
        int[] result = new int[firstPoly.Length];
        for (int i = 0; i < firstPoly.Length; i++)
        {
            result[i] = firstPoly[i] - secondPoly[i];
        }
        return result;
    }

    // Multiplication of polynomials is like when you discover brackets (както му викаме "разкриване на скоби")
    static int[] MultiplyPoly(int[] firstPoly, int[] secondPoly)
    {
        int[] result = new int[firstPoly.Length + secondPoly.Length - 1];
        for (int i = 0; i < firstPoly.Length; i++)
        {
            for (int j = 0; j < secondPoly.Length; j++)
            {
                result[i + j] += firstPoly[i] * secondPoly[j];
            }
        }
        return result;
    }

    static void PrintPoly(int[] poly)
    {
        for (int i = poly.Length - 1; i >= 0; i--)
        {
            if (i != 0)
                Console.Write(poly[i] + "*x^" + i + " + "); // Printing coefficient with x on his degree
            else
                Console.Write(poly[i]);
        }
    }
}