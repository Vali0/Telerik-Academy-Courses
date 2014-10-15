using System;

class LoanAccount : Account
{
    // Constructors
    public LoanAccount(Customer customer, decimal balance, float rate) : base(customer, balance, rate)
    {
    }

    // Properties. Overriding balance property from parent. Because loan accounts can only deposit money
    public override decimal Balance
    {
        get
        {
            return base.Balance;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("This is Loan account and you can only deposit money!");
            base.Balance += value;
        }
    }

    // Methods
    public override decimal InterestAmount(int numberOfMonths)
    {
        if (Customer.GetType().Name == "IndividualCustomer")
        {
            if (numberOfMonths <= 3)
            {
                return 0;
            }
            else
            {
                return base.InterestAmount(numberOfMonths - 3); 
                // -3 because individual customer doesn't have interest for first 3 months
            }
        }
        else if (Customer.GetType().Name == "CompanyCustomer")
        {
            if (numberOfMonths <= 2) // -2 because company customer doesn't have interest for first 3 months
            {
                return 0;
            }
            else
            {
                return base.InterestAmount(numberOfMonths - 2);
                // -2 because company customer doesn't have interest for first 3 months
            }
        }
        else
        {
            throw new ArgumentNullException("No such customer."); // For secure.
        }
    }
}