using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iibank.data
{
    public class FakeBankData
    {
        // Normally, this would be coming from a database
        public BankDataModel[] banks = new BankDataModel[]
        {
            new BankDataModel
            {
                BankId = 1,
                Name = "Fifth Third"
            },
            new BankDataModel
            {
                BankId = 2,
                Name = "Huntington"
            },
            new BankDataModel
            {
                BankId = 3,
                Name = "Chase"
            },
        };
    }
}
