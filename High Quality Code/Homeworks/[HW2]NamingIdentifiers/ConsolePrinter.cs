public class ConsolePrinterDemo
{
    private const int Max_Count = 6;

    public static void Main()
    {
        ConsolePrinter consolePrinter = new ConsolePrinter();
        consolePrinter.PrintBoolValue(true);
    }

    public class ConsolePrinter
    {
        public void PrintBoolValue(bool boolValue)
        {
            string boolValueAsString = boolValue.ToString();
            Console.WriteLine(boolValueAsString);
        }
    }
}