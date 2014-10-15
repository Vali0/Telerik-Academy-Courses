using System;

class Task10EmployeesRecord
{
    static void Main(string[] args)
    {
        //Declarating variables
        string firstName = null;
        string lastName = null;
        byte age = 0;
        char gender = '\0';
        uint idNumber = 0u;

        //Initializing variables with console input values
        Console.WriteLine("Enter your first name: ");
        firstName = Console.ReadLine();

        Console.WriteLine("Enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine("Enter your age: ");
        age = byte.Parse(Console.ReadLine());
       
        do
        {
            Console.WriteLine("Enter your gender ('m' or 'f'): ");
            gender = char.Parse(Console.ReadLine());
        }
        while (gender != 'm' && gender != 'f');
        do
        {
            Console.WriteLine("Enter your ID number(between 27560000 and 27569999): ");
            idNumber = uint.Parse(Console.ReadLine());
        }
        while (idNumber <= 27560000 || idNumber >= 27569999); // When idNumber is between these two numbers
        // Printing inputed values
        Console.WriteLine("\n\nFirst name: {0} \nLast name: {1} \nAge: {2} \nGender: {3} \nID: {4}", firstName, lastName, age, gender, idNumber);
    }
}
