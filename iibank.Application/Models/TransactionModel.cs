using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iibank.Application.Models
{
    public class TransactionModel
    {
        public int TransactionId { get; set; }
        public int ToAccountId { get; set; }
        public int ToAccountTypeId { get; set; }
        public double ToAccountBalance { get; set; }
        public int FromAccountId { get; set; }
        public int FromAccountTypeId { get; set; }
        public double FromAccountBalance { get; set; }
        public string TransactionType { get; set; }
        public double TransactionAmount { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
