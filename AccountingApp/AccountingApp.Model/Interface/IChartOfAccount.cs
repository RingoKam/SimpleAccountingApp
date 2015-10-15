using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.Model.ChartofAccount;

namespace AccountingApp.Model.Interface
{
    public interface IChartOfAccount
    {
        List<Account> LoadAccount();
        void RemoveAccount();
        void CreateAccount(Account newAccount);
        void UpdateAccount(Account updateAccount); 
    }
}
