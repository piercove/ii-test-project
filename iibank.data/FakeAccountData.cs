using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iibank.data
{
    public class FakeAccountData
    {
        // Normally, this would be coming from a database
        public AccountDataModel[] accounts = new AccountDataModel[]
        {
            new AccountDataModel
            {
                AccountId = 1,
                AccountCustomerId = 1,
                BankId = 1,
                AccountTypeId = 1,
                Balance = 2344.88
            },
            new AccountDataModel
            {
                AccountId = 2,
                AccountCustomerId = 2,
                BankId = 3,
                AccountTypeId = 3,
                Balance = 8411.55
            },
            new AccountDataModel
            {
                AccountId = 3,
                AccountCustomerId = 3,
                BankId = 2,
                AccountTypeId = 2,
                Balance = 1513.25
            },
        };
    }
}
