using System;

class IndividualCustomer : Customer
{
    // Fields
    private string firstName, secondName; // Individual customers have names

    // Constructors
    public IndividualCustomer(string firstName, string secondName, string phoneNumber) : base(phoneNumber)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
    }

    // Properties
    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            this.firstName = value;
        }
    }

    public string SecondName
    {
        get
        {
            return this.secondName;
        }
        set
        {
            this.secondName = value;
        }
    }
}