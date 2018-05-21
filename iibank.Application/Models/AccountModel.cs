using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using iibank.Application.Helpers;

namespace iibank.Application.Models
{
    public class AccountModel
    {        
        [Required(ErrorMessage = "Account Id Required")]
        public int AccountId { get; set; }

        [Required(ErrorMessage = "Customer Required")]
        public int AccountCustomerId { get; set; }
        public string CustomerName { get; set; }

        [Required(ErrorMessage ="Bank Account Required")]
        public int BankId { get; set; }
        public string BankName { get; set; }

        [Required(ErrorMessage = "Account Type Required")]
        public int AccountTypeId { get; set; }
        public string AccountTypeName { get; set; }

        [Attributes.MinValue(0)]
        public double Balance { get; set; }
    }

    
}
