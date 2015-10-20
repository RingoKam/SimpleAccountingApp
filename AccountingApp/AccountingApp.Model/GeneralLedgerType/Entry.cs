using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccountingApp.Model.GeneralLedgerType
{
    public class Entry
    {
        public DateTime TransactionDateTime { get; set; }
        public int Reference { get; set; }
        public List<Transaction> TransactionList { get; set; }
    }
}