class CompanyCustomer : Customer
{
    // Fields
    private string companyName; // Companies have company name not first name and second.

    // Constructors
    public CompanyCustomer(string companyName, string phoneNumber) : base(phoneNumber)
    {
        this.CompanyName = companyName;
    }

    // Properties
    public string CompanyName
    {
        get
        {
            return this.companyName;
        }
        set
        {
            this.companyName = value;
        }
    }
}