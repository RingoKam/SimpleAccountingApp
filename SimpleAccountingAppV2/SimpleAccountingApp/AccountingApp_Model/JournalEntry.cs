using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp_Model
{
    public class JournalEntry
    {
        int JournalEntryID { get; set; }
        DateTime Date { get; set; }
        int InvoiceID { get; set; }
    }
}
