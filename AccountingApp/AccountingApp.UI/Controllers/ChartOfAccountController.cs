﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Async;
using AccountingApp.Model;
using AccountingApp.UI.Models;
using AccoutingApp.BLL;

namespace AccountingApp.UI.Controllers
{
    public class ChartOfAccountController : Controller
    {
        // GET: ChartOfAccount
        public ActionResult ChartOfAccountList()
        {
            var mger = new AccountManager();
            var accountList = mger.GetAllAccount(); 
            return View(accountList.Attachment);
        }

        //ADD: New Account 
        public ActionResult NewChartofAccount()
        {
            var viewModel = new NewChartofAccountVM();
            viewModel.AccountTypeSelection = new SelectList(Enum.GetValues(typeof(AccountType)).Cast<AccountType>().ToList());
            viewModel.NewAcccount = null; 
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult NewChartofAccount(NewChartofAccountVM viewModel)
        {
            var mger = new AccountManager();
            mger.AddAccount(viewModel.NewAcccount);
            return RedirectToAction("ChartOfAccountList");
        }
        
        //Edit Account 
        public ActionResult EditChartofAccount(int AccountID)
        {
            var viewModel = new EditChartofAccountVM();
            var mger = new AccountManager();

            viewModel.EditAccount = mger.GetAllAccount().Attachment.FirstOrDefault(m => m.AccountID == AccountID);
            viewModel.AccountTypeSelection = new SelectList(Enum.GetValues(typeof(AccountType)).Cast<AccountType>().ToList());

            return View(viewModel);
        }


    }
}