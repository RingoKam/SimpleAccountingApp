using System;
using System.ComponentModel.DataAnnotations;
using AccountingApp.Model;
using AccountingApp.Model.GeneralLedgerType;
using System.Web.Mvc;

namespace AccountingApp.UI.Models
{
    public class NewEntryVM
    {
        [DataType(DataType.Date)]
        public DateTime TransactDateTime { get; set; }

        //the chart of account selected 
        public SelectList AccountNameSelect;

        //the the actual transaction
        public Entry newEntry { get; set; }

        //default transaction number 
        public int TransactionNumber = 2; 
    }
}