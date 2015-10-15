using System;
using System.ComponentModel.DataAnnotations;
using AccountingApp.Model;
using AccountingApp.Model.GeneralLedgerType;
using System.Web.Mvc;

namespace AccountingApp.UI.Models
{
    public class NewEntryVM
    {
        public SelectList AccountSelect;
        public SelectList AccountNameSelect; 
        public Entry newEntry { get; set; }
        [DataType(DataType.Date)]
        public DateTime TransactDateTime { get; set; }
        //default transaction number 
        public int TransactionNumber = 2; 
    }
}