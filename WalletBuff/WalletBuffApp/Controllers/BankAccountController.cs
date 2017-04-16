using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WalletBuffApp.Controllers
{
    public class BankAccountController : Controller
    {
        // GET: BankAccount
        public ActionResult Index()
        {
            return View();
        }
    }
}