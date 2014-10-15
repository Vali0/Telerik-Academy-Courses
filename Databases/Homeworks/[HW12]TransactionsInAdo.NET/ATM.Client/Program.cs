using ATM.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ATMActions.ShowCards();
            int pin = 2222;
            int cardNumber = 1222222222;
            decimal moneyToWithdraw = 300m;
            using (AtmDatabase db = new AtmDatabase())
            {
                if (ATMActions.WithdrawMoney(pin, cardNumber, moneyToWithdraw, db))
                {
                    Console.WriteLine("Money withdrawn");
                }
                else
                {
                    Console.WriteLine("Money doesn't withdrawn");
                }
            }
            
            Console.WriteLine("\nNew cards: ");
            ATMActions.ShowCards();
        }
    }
}