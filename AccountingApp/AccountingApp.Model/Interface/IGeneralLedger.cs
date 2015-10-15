using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using AccountingApp.Model.GeneralLedgerType;

namespace AccountingApp.Model.Interface
{
    public interface IGeneralLedger
    {
        List<Entry> LoadEntry(DateTime start, DateTime end);
        void RemoveEntry(Entry entry);
        void CreateEntry(Entry entry);
        void UpdateEntry(Entry entry); 
    }
}