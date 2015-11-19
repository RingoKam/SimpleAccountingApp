using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp_Model
{
    public class Transaction
    {
        int TransactionID { get; set; }
        decimal DebitAmount { get; set; }
        decimal CreditAmount { get; set; }
        int ChartofAccountID { get; set; }
        int JournalEntryID { get; set; }
    }
}
