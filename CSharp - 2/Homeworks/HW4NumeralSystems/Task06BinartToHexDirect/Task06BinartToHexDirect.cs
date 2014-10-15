using System;

//Write a program to convert binary numbers to hexadecimal numbers (directly).

class Task06BinartToHexDirect
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter your number in binary format: ");
            string binaryNumber = Console.ReadLine();
            string hexaRepresentation = null;

            for (int i = 0; i < binaryNumber.Length; i += 4)
            {
                hexaRepresentation = MakeHexidecimalRep(binaryNumber.Substring(i, 4), hexaRepresentation); // Call the method with 4 bits
            }
            Console.WriteLine("Your binary number in hexadecimal format looks like that: " + hexaRepresentation);
            // One row solution: 
            //  Console.WriteLine("Your binary number in hexadecimal format looks like that: " + Convert.ToString(Convert.ToInt32(binaryNumber, 2), 16).ToUpper());
        }
        catch (System.ArgumentOutOfRangeException)
        {
            Console.WriteLine("Wrong input!");
            Console.WriteLine("You MUST enter Math.Pow(2,n) bits - 0001 = 1 or 0001 0100 = 20");
            Console.WriteLine("If you use my one row solution which is commented little below you will not have that problem :) ");
        }
    }

    static string MakeHexidecimalRep(string index, string result)
    {
        // Checking four bit info and replace it with its hexadecimal representation
        switch (index)
        {
            case "0000":
                result += "0";
                break;
            case "0001":
                result += "1";
                break;
            case "0010":
                result += "2";
                break;
            case "0011":
                result += "3";
                break;
            case "0100":
                result += "4";
                break;
            case "0101":
                result += "5";
                break;
            case "0110":
                result += "6";
                break;
            case "0111":
                result += "7";
                break;
            case "1000":
                result += "8";
                break;
            case "1001":
                result += "9";
                break;
            case "1010":
                result += "A";
                break;
            case "1011":
                result += "B";
                break;
            case "1100":
                result += "C";
                break;
            case "1101":
                result += "D";
                break;
            case "1110":
                result += "E";
                break;
            case "1111":
                result += "F";
                break;
            default:
                result += "Error";
                break;
        }
        return result;
    }
}