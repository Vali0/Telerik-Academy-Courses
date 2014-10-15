using System;

//  *Write a program that shows the internal binary representation of given 32-bit signed 
//floating-point number in IEEE 754 format (the C# type float).
//Example: -27,25 -> sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

class Task09BinaryRepOfFloatWithSignBit
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter your float number: ");
            float number = float.Parse(Console.ReadLine());

            byte sign = 0;

            // If statement to check sign of the number
            if (number >= 0)
                sign = 0;
            else
                sign = 1;

            string temp = Convert.ToString(number); // Converting the number to string

            int counter = 0; // Counter to check the place of the pointer
            for (int i = 0; i < temp.Length; i++)
            {
                // Here I'm not sure about comma (",") checking. But I think if your visual studio or regional settings are different your separator will be "," instead "."
                if (temp.Substring(i, 1) != "." && temp.Substring(i, 1) != ",")
                    counter++;
                else
                    break;
            }

            // If the sign is '0' our substring will start at 0 position but if it is '1' it will start after the sign which is '-' (at 1 position)
            int wholePart = Convert.ToInt32(temp.Substring(sign, counter - sign)); // Value of the number before separator
            string binaryRepOFWholePart = Convert.ToString(wholePart, 2); // Converting the value before separator to its binary representation
            string exponent = Convert.ToString(127 + binaryRepOFWholePart.Length - 1, 2); // Calculating the exponent

            // Value of the number after the pointer. Simple convertion and divinding the number to make fraction number(0.xxxxxxxx)
            float fractionalPart = Convert.ToInt32(temp.Substring(counter + 1, temp.Length - counter - 1)) / (float)Math.Pow(10, temp.Length - 1 - counter);

            string mantissa = null; // Variable to remember the mantisa

            // Calculating the mantissa
            for (int i = 1; i < binaryRepOFWholePart.Length; i++)
            {
                mantissa += binaryRepOFWholePart.Substring(i, 1);
            }

            // Binary representation of the franction. Multiplication by 2 and if it is bigger than 1 we take the fraction and repeat
            // If it is less than 1 just repeat. On each multiplication we remember the integer part of the number.
            for (int i = 0; i < 23; i++)
            {
                fractionalPart *= 2;

                if (fractionalPart >= 1)
                {
                    fractionalPart -= 1;
                    mantissa += 1;
                }
                else
                {
                    mantissa += 0;
                }
            }

            // Just printing calculated values
            Console.WriteLine("Sign: " + sign);
            Console.WriteLine("Exponent: " + exponent);
            Console.WriteLine("Mantissa: " + mantissa);
        }
        catch (System.ArgumentOutOfRangeException)
        {
            Console.WriteLine("Your number isn't float!");
        }
    }
}