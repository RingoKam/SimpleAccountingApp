using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountingApp.Model;
using AccountingApp.UI.Models;
using AccoutingApp.BLL;

namespace AccountingApp.UI.Controllers
{
    public class JournalEntryController : Controller
    {
        // GET: JournalEntry
        public ActionResult NewEntry()
        {
            var gLmger = new GLManager();
            var cOAmger = new AccountManager();
            var viewModel = new NewEntryVM();
            var ChartofAccount = cOAmger.GetAllAccount();
            var AccountNames = ChartofAccount.Attachment.Select(a => a.AccountName).ToList(); 
            viewModel.AccountNameSelect = new SelectList(AccountNames);
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult NewEntry(NewEntryVM viewModel)
        {
            var mger = new GLManager();
            mger.CreateJournal(viewModel.newEntry); 
            return View(); 
        }

    }
}