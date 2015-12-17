using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccountingAppModel
{
    public class Account
    {
        public int AccountId { get; set; }
        public int AccountTypeId { get; set; }
        public string AccoutName { get; set; }
        public decimal DebitTotal { get; set; }
        public decimal CreditTotal { get; set; }
        public decimal Total { get; set; }
    }
}