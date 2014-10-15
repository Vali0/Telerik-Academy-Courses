using System;

/*A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
*/

class BankDemo
{
    static void Main(string[] args)
    {
        // Creating few instances
        DepositAccount depositIndividual = new DepositAccount(new IndividualCustomer("Tanio", "Peshev", "654321"), 1001, 5.6f);
        MortgageAccount mortIndividual = new MortgageAccount(new IndividualCustomer("Pesho", "Tanev", "123456"), 200m, 2.3f);
        LoanAccount loanIndividual = new LoanAccount(new IndividualCustomer("Tashev", "Penio", "231465"), 543, 5.3f);
        DepositAccount depositCompany = new DepositAccount(new CompanyCustomer("Telerik", "0123"), 500, 101.1f);
        MortgageAccount mortCompany = new MortgageAccount(new CompanyCustomer("DreamSpark", "0321"), 10048, 2.3f);
        LoanAccount loanCompany = new LoanAccount(new CompanyCustomer("Microsoft", "000"), 98642, 6.5f);
        // Array of accounts
        Account[] accounts = 
        {
            depositIndividual,
            mortIndividual,
            loanIndividual,
            depositCompany,
            mortCompany,
            loanCompany
        };

        // Interest of all accounts for 5 months
        foreach (var item in accounts)
        {
            Console.WriteLine("Type: {0}\nBalance: {1}\nRate: {2}\nInterest: {3}",
                item.Customer,item.Balance,item.Rate,item.InterestAmount(5));
        } 

        // I'm using property balance for transactions. Use positive value to put money or negative to draw some.
        // Can't have negative balance (provided by property). Loan and Mortgage can only deposit (again by property).

        depositIndividual.Balance = -1001;
        mortIndividual.Balance = 1000;
        depositCompany.Balance = 9999;
        // And so on...

        foreach (var item in accounts)
        {
            Console.WriteLine("Type: {0}\nBalance: {1}\nRate: {2}\nInterest: {3}",
                item.Customer, item.Balance, item.Rate, item.InterestAmount(5));
        }

        //depositIndividual.Balance = -10; // Cause an exception
        //mortIndividual.Balance = -10; // Cause an exception
        //loanIndividual.Balance = -10; // Cause an exception

        //DepositAccount exceptionAccount = new DepositAccount(
        //    new IndividualCustomer("exeption", "if you want", "404"), -1m, 666f);
    }
}