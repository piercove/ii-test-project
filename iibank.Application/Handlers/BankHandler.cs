using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iibank.Application.Models;
using iibank.data;

namespace iibank.Application.Handlers
{
    public class BankHandler
    {
        public BankModel GetBank(int bankId)
        {
            var bank = new BankModel();
            var _bank = new FakeBankData().banks.First(x => x.BankId == bankId);
            if (_bank != null)
            {
                // Normally we would use AutoMapper or equivalent
                bank.BankId = _bank.BankId;
                bank.Name = _bank.Name;

                // Get Bank Accounts
                bank.Accounts = new FakeAccountData().accounts.Select(x => new AccountModel()
                {
                    AccountId = x.AccountId,
                    AccountCustomerId = x.AccountCustomerId,
                    Balance = x.Balance,
                    AccountTypeId = x.AccountTypeId,
                    BankId = x.BankId
                }).ToList();
            }

            return bank;
        }
    }
}
