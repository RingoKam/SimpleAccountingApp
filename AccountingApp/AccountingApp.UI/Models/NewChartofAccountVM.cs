using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using AccountingApp.Model.ChartofAccount;

namespace AccountingApp.UI.Models
{
    public class NewChartofAccountVM
    {
        public SelectList AccountTypeSelection { get; set; }
        public Account NewAcccount { get; set; }
    }
}
