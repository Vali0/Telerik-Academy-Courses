using System;

//Write a program to convert hexadecimal numbers to binary numbers (directly).

class Task05HexToBinary
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your hexadecimal number: ");
        string hexNumber = Console.ReadLine().ToUpper();
        
        //One row solution:
        //Console.WriteLine("Your hexadecimal number in binary format looks like that: \n" + Convert.ToString(Convert.ToInt32(hexNumber, 16), 2).PadLeft(32,'0'));
        
        string binaryRepresentation = null;
        for (int i = 0; i < hexNumber.Length; i++)
        {
            binaryRepresentation = MakeBinaryRep(hexNumber.Substring(i, 1), binaryRepresentation); // Call the method
        }
        Console.WriteLine("Directly binary representation of your hexadecimal number is: \n" + binaryRepresentation.PadLeft(32, '0'));
    }

    static string MakeBinaryRep(string index, string result)
    {
        // Check the bit and replace it with his four bit binary representation
        switch (index)
        {
            case "0":
                result += "0000";
                break;
            case "1":
                result += "0001";
                break;
            case "2":
                result += "0010";
                break;
            case "3":
                result += "0011";
                break;
            case "4":
                result += "0100";
                break;
            case "5":
                result += "0101";
                break;
            case "6":
                result += "0110";
                break;
            case "7":
                result += "0111";
                break;
            case "8":
                result += "1000";
                break;
            case "9":
                result += "1001";
                break;
            case "A":
                result += "1010";
                break;
            case "B":
                result += "1011";
                break;
            case "C":
                result += "1100";
                break;
            case "D":
                result += "1101";
                break;
            case "E":
                result += "1110";
                break;
            case "F":
                result += "1111";
                break;
            default:
                result += "Error";
                break;
        }
        return result;
    }
}