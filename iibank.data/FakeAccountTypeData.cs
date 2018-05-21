using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iibank.data
{
    public class FakeAccountTypeData
    {
        // Normally, this would be coming from a database
        public AccountTypeDataModel[] accountTypes = new AccountTypeDataModel[]
        {
            new AccountTypeDataModel
            {
                AccountTypeId = 1,
                Name = "Checking"
            },
            new AccountTypeDataModel
            {
                AccountTypeId = 2,
                Name = "Corporate Investment"
            },
            new AccountTypeDataModel
            {
                AccountTypeId = 3,
                Name = "Individual Investment"
            }
        };
    }
}
