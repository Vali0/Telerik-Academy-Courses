using System;

class Task13NullValues
{
    static void Main(string[] args)
    {
        //Output methods shows what is doing 
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine("Nullable variables or default values: int: {0}, double: {1}", nullInt.GetValueOrDefault(), nullDouble.GetValueOrDefault());
        Console.WriteLine("Nullable variables (with actual values): int: {0}, double: {1}", nullInt, nullDouble);
        nullInt += null;
        nullDouble += 2.7182818284;
        Console.WriteLine("Variables with adding into them or default values: int: {0}, double: {1}", nullInt.GetValueOrDefault(), nullDouble.GetValueOrDefault());
        Console.WriteLine("Variables with adding into them (with actual values): int: {0}, double: {1}", nullInt, nullDouble);
        nullInt = 2;
        nullDouble = 3.14159265;
        Console.WriteLine("Variables with new assigns or default values: int: {0}, double: {1}", nullInt.GetValueOrDefault(), nullDouble.GetValueOrDefault());
        Console.WriteLine("Variables with new assigns (with actual values): int: {0}, double: {1}", nullInt, nullDouble);
    }
}
