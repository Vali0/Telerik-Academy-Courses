abstract class Customer 
{
    // Fields
    private string phoneNumber; // Only that field because different customers. It is the same for all customers.

    // Constructors
    public Customer(string phoneNumber)
    {
        this.PhoneNumber = phoneNumber;
    }

    // Properties
    public string PhoneNumber
    {
        get
        {
            return this.phoneNumber;
        }
        set
        {
            this.phoneNumber = value;
        }
    }
}