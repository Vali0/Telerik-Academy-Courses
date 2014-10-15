using System;

class Task02SignOfTheProduct
{
    static void Main(string[] args)
    {
        try
        {
            // Defining and initializing variables
            double firstNumber, secondNumber, thirdNumber;
            Console.WriteLine("Enter first number: ");
            firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            thirdNumber = double.Parse(Console.ReadLine());

            // Defining bool variables with values true or false depending of the numbers
            bool firstNumberSign = firstNumber > 0;
            bool seconNumberSign = secondNumber > 0;
            bool thirdNumberSign = thirdNumber > 0;


            if (firstNumberSign ^ seconNumberSign ^ thirdNumberSign)
            {
                Console.WriteLine("Product is positive!");
            }
            else
            {
                Console.WriteLine("Product is negative!");
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You entered letter or symbol!");
        }
        }
}
