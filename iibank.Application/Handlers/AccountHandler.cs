using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iibank.Application.Models;
using iibank.data;

namespace iiaccount.Application.Handlers
{
    public class AccountHandler
    {
        public List<AccountModel> GetAccounts()
        {
            var accounts = new FakeAccountData().accounts.Select(x => new AccountModel()
            {
                AccountId = x.AccountId,
                AccountCustomerId = x.AccountCustomerId,
                Balance = x.Balance,
                AccountTypeId = x.AccountTypeId,
                BankId = x.BankId
            }).ToList();

            return accounts;
        }
    }
}
