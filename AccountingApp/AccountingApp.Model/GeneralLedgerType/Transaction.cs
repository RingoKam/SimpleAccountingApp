using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.Model.ChartofAccount;

namespace AccountingApp.Model.GeneralLedgerType
{
    public class Transaction
    {
        public Account Account { get; set; }
        public DebitCredit DebitOrCredit { get; set; }
        public string CustomerVendor { get; set; }
        public string Description { get; set; }
        public string TransactionDescription { get; set; }
        public decimal Amount { get; set; }
    }
}