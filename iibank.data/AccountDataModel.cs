using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iibank.data
{
    public class AccountDataModel
    {
        public int AccountId { get; set; }
        public int AccountCustomerId { get; set; }
        public int BankId { get; set; }
        public int AccountTypeId { get; set; }
        public double Balance { get; set; }
    }
}
