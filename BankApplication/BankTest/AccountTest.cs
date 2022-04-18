
using BankApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankTest
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void checkDeposit()
        {
            var bankn = new DemoAccount();
            bankn.Deposite(1000);
            Assert.Equals(1000, bankn.Balance);
            Assert.AreNotEqual(1000, bankn.Balance);
           
        }
    }
}
