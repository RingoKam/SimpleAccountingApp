using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using SimpleAccountingApp.Models;

namespace SimpleAccountingApp.Controllers
{
    public class AccountController : ApiController
    {
        public ChartofAccountsVM Get()
        {
            var account = new ChartofAccountsVM();

            return account;
        }

    }
}
