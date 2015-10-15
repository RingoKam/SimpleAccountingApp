using System.Collections.Generic;
using System.Linq;
using AccountingApp.Model.ChartofAccount;
using AccountingApp.Model.GeneralLedgerType;
using AccountingApp.Model.Interface;

namespace AccountingApp.Data
{
    public class ChartOfAccount_Mock: IChartOfAccount
    {
        private static List<Account> chartofAccount;

        public List<Account> LoadAccount()
        {
            return chartofAccount;
        }

        //Delete
        public void RemoveAccount()
        {
            //TODO: implement remove 
        }
            
        //Create 
        public void CreateAccount(Account newAccount)
        {
            chartofAccount.Add(newAccount);
        }

        //Update
        public void UpdateAccount(Account updateAccount)
        {
            //time is to the nano second? should serve as a good primary key 
            var result =
                chartofAccount.FirstOrDefault(
                    e => e.AccountType == updateAccount.AccountType && e.AccountName == updateAccount.AccountName);

            int index = chartofAccount.IndexOf(result);

            chartofAccount[index] = updateAccount;
        }
    }
}