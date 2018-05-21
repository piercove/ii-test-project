using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iibank.Application.Models
{
    public class BankModel
    {
        public int BankId { get; set; }
        public string Name { get; set; }
        public List<AccountModel> Accounts = new List<AccountModel>();
    }
}
