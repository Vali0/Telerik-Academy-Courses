using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ATM.Data;
using ATM.Model;
using ATM.Client;
using System.Linq;

namespace AtmDatabaseTest
{
    [TestClass]
    public class WithdrawTests
    {
        [TestMethod]
        public void CheckRecordNumber()
        {
            decimal money = 2000;
            decimal toWithdraw = 1000;
            int number = 1111111111;
            int cardPin = 1111;
            using (var db = new AtmDatabase())
            {
                db.CardAccounts.Add(new CardAccount() { CardCash = money, CardNumber = number, CardPIN = cardPin });
                db.SaveChanges();
                ATMActions.WithdrawMoney(cardPin, number, toWithdraw, db);
                db.SaveChanges();
                var actual = (from c in db.TransactionsHistory
                              select c).First();
                Assert.AreEqual(number, actual.CardNumber);
                db.Dispose();
            }
        }
        [TestMethod]
        public void CheckRecordAmount()
        {
            decimal money = 2000;
            decimal toWithdraw = 1000;
            int number = 1111111111;
            int cardPin = 1111;
            using (var db = new AtmDatabase())
            {
                db.CardAccounts.Add(new CardAccount() { CardCash = money, CardNumber = number, CardPIN = cardPin });
                db.SaveChanges();
                ATMActions.WithdrawMoney(cardPin, number, toWithdraw, db);
                db.SaveChanges();
                var actual = (from c in db.TransactionsHistory
                              select c).First();
                Assert.AreEqual(1000, actual.Ammount);
                db.Dispose();
            }
        }
    }
}