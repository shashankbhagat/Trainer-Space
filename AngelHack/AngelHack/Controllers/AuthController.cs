using AngelHack.DataLayer;
using AngelHack.Models;
using AngelHack.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngelHack.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            Account a = new Account();
            return View(a);
        }

        [HttpPost]
        public ActionResult Login(Account a)
        {
            if (ModelState.IsValid)
            {
                bool result = RepositoryAuth.VerifyLogin(a.UserName, a.Password);
                if (result == true)
                {
                    ViewBag.msg = "Welcome " + a.UserName;
                    SessionFacade.LOGGEDIN = a.UserName;
                    if (SessionFacade.REDIRECTURL != null)
                        return Redirect(SessionFacade.REDIRECTURL);
                }
                else
                    ViewBag.msg = "Invalid Login....";
            }
            return RedirectToAction("Welcome", "Home");
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}

