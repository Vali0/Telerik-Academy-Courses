using System;

class Task03CompanyInformation
{
    static void Main(string[] args)
    {
        //Defining values
        string companyName, companyAddress, companyWebSite, managerFirstName, managerLastName;
        uint companyPhoneNumber, companyFaxNumber, managerPhoneNumber;
        byte managerAge = 0;

        // Reading values
        Console.WriteLine("Enter the company name: ");
        companyName = Console.ReadLine();
        Console.WriteLine("Enter the company address: ");
        companyAddress = Console.ReadLine();
        Console.WriteLine("Enter the company phone number: ");
        companyPhoneNumber = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter the company fax number: ");
        companyFaxNumber = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter the company web site: ");
        companyWebSite = Console.ReadLine();
        Console.WriteLine("Enter manager first name: ");
        managerFirstName = Console.ReadLine();
        Console.WriteLine("Enter manager last name: ");
        managerLastName = Console.ReadLine();
        Console.WriteLine("Enter manager age: ");
        managerAge = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter manager phone number: ");
        managerPhoneNumber = uint.Parse(Console.ReadLine());

        // Printing the information
        Console.WriteLine("Company name: {0} \nCompany address: {1} \nCompany phone number: {2} \nCompany fax number: {3}",
            companyName, companyAddress, 
            Convert.ToString(companyPhoneNumber).PadLeft(Convert.ToString(companyPhoneNumber).Length + 1, '0'),
            Convert.ToString(companyFaxNumber).PadLeft(Convert.ToString(companyFaxNumber).Length + 1, '0')); 
        // Using PadLeft() to print the '0' at the console using uint type!
        Console.WriteLine("Company web site {0} \nManager first name: {1} \nManager last name: {2} \nManager age: {3} \nManager phone number: {4}",
            companyWebSite, managerFirstName, managerLastName, managerAge, 
            Convert.ToString(managerPhoneNumber).PadLeft(Convert.ToString(managerPhoneNumber).Length + 1, '0'));
    }
}