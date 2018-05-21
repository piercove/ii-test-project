using Microsoft.VisualStudio.TestTools.UnitTesting;
using iiaccount.Application.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iibank.Application.Handlers;

namespace iiaccount.Application.Handlers.Tests
{
    [TestClass()]
    public class AccountHandlerTests
    {
        [TestMethod()]
        public void MakeSureAccountsHaveCustomerTest()
        {
            var ah = new AccountHandler();
            var result = ah.GetAccounts();

            foreach (var account in result)
            {
                if (account.AccountCustomerId == 0)
                {
                    Assert.Fail();
                }
            }
        }
    }
}