using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.Model;
using AccountingApp.Model.GeneralLedgerType;

namespace AccoutingApp.BLL
{
    internal static class BusinessLogicValidations
    {
        internal static bool DebitCreditValid(Entry validateEntry)
        {
            decimal debitTotal = 0;
            decimal crediTotal = 0;
            foreach (var transaction in validateEntry.TransactionList)
            {
                if (transaction.DebitOrCredit == DebitCredit.Credit)
                {
                    crediTotal += transaction.Amount;
                }
                else
                {
                    debitTotal += transaction.Amount;
                }
            }
            if (debitTotal == crediTotal)
            {
                return true; 
            }
            return false;
        }
    }
}
