using Microsoft.VisualStudio.TestTools.UnitTesting;
using iibank.Application.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iibank.Application.Handlers.Tests
{
    [TestClass()]
    public class BankHandlerTests
    {
        [TestMethod()]
        public void GetBankAccountsTest()
        {
            var bh = new BankHandler();
            var result = bh.GetBank(1);

            Assert.IsNotNull(result.Accounts);
        }
    }
}