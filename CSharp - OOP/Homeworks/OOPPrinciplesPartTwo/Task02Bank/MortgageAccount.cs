using System;

class MortgageAccount : Account
{
    // Constructors
    public MortgageAccount(Customer customer, decimal balance, float rate) : base(customer, balance, rate)
    {
    }

    // Properties
    public override decimal Balance
    {
        get
        {
            return base.Balance;
        }
        set
        {
            if (value < 0) // this kind of account can only deposit money. So if he try to draw money it will cause exception
                throw new ArgumentException("This is Mortgage account and you can only deposit money!");
            base.Balance += value;
        }
    }

    // Methods
    public override decimal InterestAmount(int numberOfMonths)
    {
        if (Customer.GetType().Name == "IndividualCustomer")
        {
            if (numberOfMonths <= 6)
            {
                return 0;
            }
            else
            {
                return base.InterestAmount(numberOfMonths - 6); 
                // -6 because individual customer doesn't have interest for first 3 months
            }
        }
        else if (Customer.GetType().Name == "CompanyCustomer")
        {
            if (numberOfMonths <= 12)
            {
                return base.InterestAmount(numberOfMonths) / 2;
            }
            else
            {
                return base.InterestAmount(12) / 2 + // /2 because company customer got half interest for first 12 months
                       base.InterestAmount(numberOfMonths - 12);
                // -12 because company customer doesn't have interest for first 3 months
            }
        }
        else
        {
            throw new ArgumentNullException("No such customer.");
        }
    }
}