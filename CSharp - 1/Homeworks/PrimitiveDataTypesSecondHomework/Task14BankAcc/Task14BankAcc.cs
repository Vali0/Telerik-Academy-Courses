using System;

class Task14BankAcc
{
    static void Main(string[] args)
    {
        // Declarating variables
        string firstName, middleName, lastName, bankName, IBAN, BIC;
        decimal ballance;
        ulong creditCardNumber1, creditCardNumber2, creditCardNumber3;
        // Initializing variables
        firstName = "Valentin";
        middleName = "Rumenov";
        lastName = "Radev";
        bankName = "Bulbank";
        IBAN = "CH100023000A109822346";
        BIC = "NL91";
        ballance = 1243165.99m;
        creditCardNumber1 = 4000080706200002;
        creditCardNumber2 = 4321567890121234;
        creditCardNumber3 = 5588320123456789;
        // Printing variables
        Console.WriteLine("Full name: " + firstName + " " + middleName + " " + lastName);
        Console.WriteLine("Bank name: " + bankName);
        Console.WriteLine("IBAN: " + IBAN + "\nBIC: " + BIC + "\nBallance: " + ballance);
        Console.WriteLine("Credit card numbers: " + creditCardNumber1 + " " + creditCardNumber2 + " " + creditCardNumber3);
    }
}
