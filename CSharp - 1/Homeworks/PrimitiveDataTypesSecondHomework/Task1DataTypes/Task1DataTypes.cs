using System;

class Task1DataTypes
{
    static void Main(string[] args)
    {
        //Declarating variables
        ushort uShortType = 52130; // Under 65.535
        sbyte sByteType = -115; // Above -128
        int intType = 4825932; // Could be uint too
        byte byteType = 97; // Under 255
        short shortType = -10000; // Under -32.768

        //Printing initialized variables
        Console.WriteLine("uShort:" + uShortType);
        Console.WriteLine("sByte: " + sByteType);
        Console.WriteLine("int: " + intType);
        Console.WriteLine("byte: " + byteType);
        Console.WriteLine("short: " + shortType);
    }
}

