using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAccountingApp.Models.SubModels
{
    public class AccountVM
    {
        public int AccountId { get; set; }
        public int AccountTypeId { get; set; }
        public string AccoutName { get; set; }
        public decimal DebitTotal { get; set; }
        public decimal CreditTotal { get; set; }
        public decimal Total { get; set; }
    }
}