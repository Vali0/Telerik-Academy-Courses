using System;

class DepositAccount : Account
{
    // Constructors
    public DepositAccount(Customer customer, decimal balance, float rate) : base(customer, balance, rate)
    {
    }

    // Properties. Overriding balance property from parent.
    public override decimal Balance
    {
        get
        {
            return base.Balance;
        }
        set
        {
            if (value < 0)
            {
                if (base.Balance + value < 0) // Prevent from getting much money than you have.
                    throw new ArithmeticException("You don't have enough money");
            }
            base.Balance += value;
        }
    }
    
    // Methods
    public override decimal InterestAmount(int numberOfMonths)
    {
        if (Balance >= 0 && Balance <= 1000)
        {
            return 0;
        }
        else
        {
            return base.InterestAmount(numberOfMonths);
        }
        // Can't be less because property.
    }
}