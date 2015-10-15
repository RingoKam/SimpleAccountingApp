using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using AccountingApp.Model.GeneralLedgerType;
using AccountingApp.Model.Interface;

namespace AccountingApp.Data
{
    public class GeneralLedger_Mock: IGeneralLedger
    {
        private static List<Entry> theLedger;

        //read
        public List<Entry> LoadEntry(DateTime start, DateTime end)
        {
            List<Entry> list = new List<Entry>();
            foreach (var entry in theLedger)
            {
                if (entry.TransactionDateTime > start && entry.TransactionDateTime < end)
                {
                    list.Add(entry);
                }
            }
            return list; 
        }

        //Delete
        public void RemoveEntry(Entry entry)
        {
            //TODO: implement remove 
        }

        //Create 
        public void CreateEntry(Entry entry)
        {
            theLedger.Add(entry);
        } 

        //Update
        public void UpdateEntry(Entry entry)
        {
            //time is to the nano second? should serve as a good primary key 
            var result =
                theLedger.FirstOrDefault(
                    e => e.TransactionDateTime == entry.TransactionDateTime && e.Reference == entry.Reference);

            int index = theLedger.IndexOf(result);

            theLedger[index] = entry; 
        }

    }
}