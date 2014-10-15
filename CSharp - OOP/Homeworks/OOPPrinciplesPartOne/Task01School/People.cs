using System;

abstract class People : Comment // abstract because Teacher and Student classes and inherit Comment which one inherit 
// ICommentable Interface. I use other class for implementation of interface because Discipline and Class classes
// Because they use this interface too and will be stupid to implement this method for each class.
{
    // Fields
    private string firstName, lastname;

    // Constructors
    public People(string firstName, string lastname)
    {
        this.FirstName = firstName;
        this.Lastname = lastname;
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
                throw new ArgumentNullException("Must have first name");
            this.firstName = value;
        }
    }

    public string Lastname
    {
        get
        {
            return this.lastname;
        }
        set
        {
            if (value == null)
                throw new ArgumentNullException("Must have last name");
            this.lastname = value;
        }
    }
}