using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp.Model.GeneralLedgerType
{
    public class Transaction
    {
        public AccountType Account { get; set; }
        public string AccountName { get; set; }
        public string TransactionDescription { get; set; }
        public decimal Amount { get; set; }
    }
}