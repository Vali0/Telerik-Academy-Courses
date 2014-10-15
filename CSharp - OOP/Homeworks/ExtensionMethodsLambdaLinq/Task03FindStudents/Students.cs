using System;
using System.Text;

class Students
{
    // Fields
    private string firstName, lastName;
    private byte age;

    // Properties
    public byte Age
    {
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
    }

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

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            this.lastName = value;
        }
    }

    // ToString() overriding
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append("{");
        result.Append(String.Format(" FirstName = {0}, LastName = {1}, Age = {2} ", this.FirstName, this.LastName, this.Age));
        result.Append("}");
        return result.ToString();
    }
}