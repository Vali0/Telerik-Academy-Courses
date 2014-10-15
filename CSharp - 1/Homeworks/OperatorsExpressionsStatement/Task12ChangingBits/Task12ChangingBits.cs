using System;

class Task12ChangingBits
{
    static void Main(string[] args)
    {
        int number, bitValue, bitPosition, mask, result;
        Console.WriteLine("Enter the number: ");

        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Number in binary format: " + Convert.ToString(number, 2).PadLeft(32, '0'));
        // Try statemant for bit input (if it is a real number)
        try
        {
            do
            {
                Console.WriteLine("Enter bit value (0 or 1): ");
                bitValue = int.Parse(Console.ReadLine());
            }
            while (bitValue != 0 && bitValue != 1);

            Console.WriteLine("Enter bit position: ");
            bitPosition = int.Parse(Console.ReadLine());

            if (bitValue == 1)
            {
                mask = 1 << bitPosition;
                result = number | mask;
                Console.WriteLine("New number is: " + result);
                Console.WriteLine("Number in binary format: " + Convert.ToString(result, 2).PadLeft(32, '0'));
            }
            else
            {
                mask = ~(1 << bitPosition);
                result = number & mask;
                Console.WriteLine("New number is: " + result);
                Console.WriteLine("Number in binary format: " + Convert.ToString(result, 2).PadLeft(32, '0'));
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You entered a real bit!");
        }
    }
}
