using Microsoft.VisualStudio.TestTools.UnitTesting;
using iibank.Application.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iibank.Application.Models;

namespace iibank.Application.Handlers.Tests
{
    [TestClass()]
    public class TransactionHandlerTests
    {
        [TestMethod()]
        public void SimpleDepositTest()
        {
            var th = new TransactionHandler();
            var result = th.Deposit(4500.00, 3);

            Assert.IsNotNull(result);
            Assert.AreEqual(result, "Success");
        }

        [TestMethod()]
        public void WithdrawOverLimitTest()
        {
            // Only Account 2 is of the type "Individual Investment"
            var th = new TransactionHandler();
            var result = th.Withdraw(1200, 2);

            Assert.AreNotEqual(result, "Success");
        }

        [TestMethod()]
        public void WithdrawOverBalanceTest()
        {
            var th = new TransactionHandler();
            var result = th.Withdraw(65000, 1);

            Assert.AreNotEqual(result, "Success");
        }

        [TestMethod()]
        public void WithdrawUnderLimitTest()
        {
            var th = new TransactionHandler();
            var result = th.Withdraw(1000, 3);

            Assert.AreEqual(result, "Success");
        }

        [TestMethod()]
        public void TransferNormalTest()
        {
            var th = new TransactionHandler();
            var result = th.Transfer(1000, 1, 2);

            Assert.AreEqual(result, "Success");
        }

        [TestMethod()]
        public void TransferOverBalanceTest()
        {
            var th = new TransactionHandler();
            var result = th.Transfer(65000, 2, 3);

            Assert.AreNotEqual(result, "Success");
        }
        
    }
}