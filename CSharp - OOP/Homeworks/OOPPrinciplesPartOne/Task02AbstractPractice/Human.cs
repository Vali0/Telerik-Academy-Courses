using System;

abstract class Human
{
    // Fields
    private string firstName, lastName;

    // Constructor
    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
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
            if (value == null)
                throw new ArgumentNullException("Must have name!");
            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            if (value == null)
                throw new ArgumentNullException("Must have name!");
            this.lastName = value;
        }
    }
}