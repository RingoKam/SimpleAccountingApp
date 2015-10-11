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
            var mger = new GLManager();
            var viewModel = new NewEntryView();
            //TODO: Insert AccountName to viewModel 
            var accountTypeSelectList= Enum.GetValues(typeof (AccountType)).Cast<AccountType>().ToList();  
            viewModel.AccountSelect = new SelectList(accountTypeSelectList);
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult NewEntry(NewEntryView viewModel)
        {
            var mger = new GLManager();

            return View(); 
        }

    }
}