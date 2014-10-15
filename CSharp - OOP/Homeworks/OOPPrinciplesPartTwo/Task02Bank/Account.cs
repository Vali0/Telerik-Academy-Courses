
abstract class Account : IInterest
{
    // Fields
    private Customer customer;
    private decimal balance;
    private float rate;

    // Constructors
    public Account(Customer customer, decimal ballance, float rate)
    {
        this.Customer = customer;
        this.Balance = ballance;
        this.Rate = rate;
    }

    // Properties
    public Customer Customer
    {
        get
        {
            return this.customer;
        }
        protected set
        {
            this.customer = value;
        }
    }
    
    public virtual decimal Balance // Virtual because different accounts
    {
        get
        {
            return this.balance;
        }
        set
        {
            this.balance = value;
        }
    }

    public float Rate
    {
        get
        {
            return this.rate;
        }
        set
        {
            this.rate = value;
        }
    }

    // Methods
    public virtual decimal InterestAmount(int numberOfMonths)
    {
        return (decimal)(Balance * (1 + ((decimal)(Rate / 100)) * numberOfMonths)); // I use formula for simple interest
        // Don't be pedantic its simple formula... I'm not banker either.
    }
}