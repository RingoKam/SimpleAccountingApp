using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountingApp.Model.ChartofAccount;

namespace AccountingApp.UI.Models
{
    public class EditChartofAccountVM
    {
        public Account EditAccount { get; set; }
        public SelectList AccountTypeSelection { get; set; }
    }
}